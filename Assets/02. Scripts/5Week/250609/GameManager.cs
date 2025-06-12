using TMPro;
using UnityEngine;

namespace Cat
{
    public class GameManager : MonoBehaviour
    {
        public SoundManager SoundManager;

        public TextMeshProUGUI playTimeUI;
        public TextMeshProUGUI scoreUI;

        private static float timer;
        public static int score; // 사과를 먹은 개수
        public static bool isPlay;

        void Start()
        {
            SoundManager.SetBGMSound("Intro");
        }


        void Update()
        {
            if (!isPlay) return;

            timer += Time.deltaTime;
            // playTimeUI.text = timer.ToString(); // 숫자형 타입을 string으로 형 변환
            playTimeUI.text = string.Format("플레이 시간 : {0:F1}초", timer);

            scoreUI.text = $"X {score}";
        }

        public static void ResetPlayUI()
        {
            timer = 0f;
            score = 0;
        }
    }
}
