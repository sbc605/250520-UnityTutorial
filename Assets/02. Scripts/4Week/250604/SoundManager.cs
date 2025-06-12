using UnityEngine;

namespace Cat
{
    public class SoundManager : MonoBehaviour
    {
        public GameObject fadeUI;

        public AudioSource audioSource;
        public AudioClip jumpClip;
        public AudioClip playBgmClip;
        public AudioClip introBgmClip;
        public AudioClip colliderClip;


        public void SetBGMSound(string bgmName)
        {
            if (bgmName == "Intro")
            {
                audioSource.clip = introBgmClip;
            }
            else if (bgmName == "Play")
            {
                audioSource.clip = playBgmClip;
            }

            audioSource.loop = true; // 시작할 때 자동재생
            audioSource.volume = 0.1f; // 소리 음량

            audioSource.Play(); // 시작

            // audioSource.playOnAwake = true; // 반복
        }

        public void OnJumpSound()
        {
            audioSource.PlayOneShot(jumpClip);
        }

        public void OnColliderSound()
        {
            audioSource.PlayOneShot(colliderClip);
        }

    }
}

