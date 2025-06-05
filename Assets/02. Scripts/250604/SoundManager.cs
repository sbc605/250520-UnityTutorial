using UnityEngine;

namespace Cat
{
    public class SoundManager : MonoBehaviour
    {
        public GameObject fadeUI;

        public AudioSource audioSource;
        public AudioClip jumpClip;
        public AudioClip bgmClip;

        private void Start()
        {
            SetBGMSound();
        }

        public void SetBGMSound()
        {
            audioSource.clip = bgmClip; // ����� �ҽ��� ���� ���� ����
            audioSource.playOnAwake = true; // �ݺ�
            audioSource.loop = true; // ������ �� �ڵ����
            audioSource.volume = 0.1f; // �Ҹ� ����

            audioSource.Play(); // ����

        }

        public void OnJumpSound()
        {
            audioSource.PlayOneShot(jumpClip); // �̺�Ʈ ����
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                audioSource.Stop();
            }
        }

    }
}

