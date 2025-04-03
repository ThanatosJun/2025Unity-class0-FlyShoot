using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;


namespace Test{
    public class UIAndSceneManager : MonoBehaviour
    {
        public static UIAndSceneManager instance;
        private CanvasGroup groupUI;
        private TextMeshProUGUI textTitle;
        private Button btnReplay;

        private void Awake()
        {
            instance = this;
            groupUI = GameObject.Find("gameEnd-canvas").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("EndingTitle").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("RestartButton").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        public void UpdateUIAndShow(string title)
        {
            textTitle.text = title;
            StartCoroutine(ShowGroup());
        }

        private IEnumerator ShowGroup()
        {
            for (int i = 0; i < 10; i++)
            {
                groupUI.alpha += 0.1f;
                yield return new WaitForSeconds(0.03f);
            }
            Time.timeScale = 0f;
            AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
            foreach (AudioSource audioSource in allAudioSources)
            {
                audioSource.Pause();
            }
        }

        private void Replay()
        {
            Time.timeScale = 1f;
            AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
            foreach (AudioSource audioSource in allAudioSources)
            {
                audioSource.UnPause();
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
