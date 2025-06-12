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
        public static int score; // ����� ���� ����
        public static bool isPlay;

        void Start()
        {
            SoundManager.SetBGMSound("Intro");
        }


        void Update()
        {
            if (!isPlay) return;

            timer += Time.deltaTime;
            // playTimeUI.text = timer.ToString(); // ������ Ÿ���� string���� �� ��ȯ
            playTimeUI.text = string.Format("�÷��� �ð� : {0:F1}��", timer);

            scoreUI.text = $"X {score}";
        }

        public static void ResetPlayUI()
        {
            timer = 0f;
            score = 0;
        }
    }
}
