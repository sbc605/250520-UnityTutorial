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

            audioSource.loop = true; // ������ �� �ڵ����
            audioSource.volume = 0.1f; // �Ҹ� ����

            audioSource.Play(); // ����

            // audioSource.playOnAwake = true; // �ݺ�
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

