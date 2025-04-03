using UnityEngine;
namespace Test
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;
        private AudioSource aud;
        private void Awake()
        {
            instance = this;
            aud = GetComponent<AudioSource>();
        }

        public void PlaySound(AudioClip sound, float volume)
        {
            aud.PlayOneShot(sound, volume);
        }
    }
}