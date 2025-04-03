using UnityEngine;

namespace Test
{
    public class EndManager : MonoBehaviour
    {
        [SerializeField, Header("觸發結束的物件名稱")]
        private string nameObject = "player-flyer";

        private FighterControl fighterControl;
        private FighterShootPlayer fighterShootPlayer;

        private void Awake()
        {
            fighterControl = FindObjectOfType<FighterControl>();
            fighterShootPlayer = FindObjectOfType<FighterShootPlayer>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            End(collision.name);
        }

        private void End(string collisionName)
        {
            if (collisionName.Contains(nameObject))
            {
                fighterControl.enabled = false;
                fighterShootPlayer.enabled = false;
                UIAndSceneManager.instance.UpdateUIAndShow("恭喜通關");
            }
        }

    }
}
