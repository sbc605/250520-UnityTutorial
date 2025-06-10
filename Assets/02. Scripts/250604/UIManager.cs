using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public GameObject playObj;
        public GameObject introUI;
        public GameObject playUI;
        public SoundManager SoundManager;


        public TMP_InputField inputText;
        public TextMeshProUGUI nameTextUI;

        public Button startButton;

        private void Awake()
        {
            playObj.SetActive(false);
            playUI.SetActive(false);
            introUI.SetActive(true);
        }

        private void Start()
        {
            startButton.onClick.AddListener(OnStartButton);
        }

        public void OnStartButton()
        {
            bool isNoText = inputText.text == "";

            if (isNoText)
            {
                Debug.Log("입력한 텍스트 없음");
            }
            else
            {
                nameTextUI.text = inputText.text; // 인풋필드 컴포넌트(입력값) = 텍스트메쉬 컴포넌트(고양이 이름)
                SoundManager.SetBGMSound("Play");

                GameManager.isPlay = true;

                playObj.SetActive(true);
                playUI.SetActive(true);
                introUI.SetActive(false);
            }
        }
    }
}

