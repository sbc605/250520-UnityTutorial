using UnityEngine;

namespace Cat
{

    public class SoundManager : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip jumpClip;
        public AudioClip bgmClip;

        private void Start()
        {
            SetBGMSound();
        }

        public void SetBGMSound()
        {
            audioSource.clip = bgmClip; // 오디오 소스에 사운드 파일 설정
            audioSource.playOnAwake = true; // 반복
            audioSource.loop = true; // 시작할 때 자동재생
            audioSource.volume = 0.1f; // 소리 음량

            audioSource.Play(); // 시작

        }

        public void OnJumpSound()
        {
            audioSource.PlayOneShot(jumpClip); // 이벤트 사운드

        }

    }
}

