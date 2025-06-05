using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public GameObject playObj;
        public GameObject introUI;

        public TMP_InputField inputText;
        public TextMeshProUGUI nameTextUI;

        public Button startButton;

        private void Start()
        {
            startButton.onClick.AddListener(OnStartButton);
        }

        public void OnStartButton()
        {
            bool isNoText = inputText.text == "";

            if (isNoText)
            {
                Debug.Log("�Է��� �ؽ�Ʈ ����");
            }
            else
            {
                playObj.SetActive(true);
                introUI.SetActive(false);
                Debug.Log($"{nameTextUI.text} �Է�");
                nameTextUI.text = inputText.text; // ��ǲ�ʵ� ������Ʈ(�Է°�) = �ؽ�Ʈ�޽� ������Ʈ(����� �̸�)
            }


        }
    }
}

