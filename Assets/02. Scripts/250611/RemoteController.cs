using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    public GameObject videoScreen;
    public Button[] buttonUI;

    private VideoPlayer videoPlayer;

    //  public bool isOn = false; // ��ũ�� ���� ����(�⺻ ����)
    public bool isMute = false;

    public VideoClip[] clips;
    public int clipIndex; // ���� ���� �ε���



    private void Awake()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = clips[0]; // Default ���� ����
    }


    private void Start()
    {
        buttonUI[0].onClick.AddListener(OnScreenPower);
        buttonUI[1].onClick.AddListener(OnMute);
        buttonUI[2].onClick.AddListener(OnPrevChannel);
        buttonUI[3].onClick.AddListener(OnNextChannel);
    }

    public void OnScreenPower()
    {

        videoScreen.SetActive(!videoScreen.activeSelf); // ������Ʈ ���� ���

        //isOn = !isOn;
        //videoScreen.SetActive(isOn); // ���� Active On/Off ���

        //bool isScreenOn = videoScreen.activeSelf; // Active On�� ���: true // Active ���� �Ǻ� ���


        /* ���� �� �ڵ�
        if (!isOn)
        {
            videoScreen.SetActive(true);
            isOn = true; // ���� Ƽ�� On

        }
        else // (isOn == true)
        {
            videoScreen.SetActive(false);
            isOn = false;
        } */
        /* ���ڵ�
        public VideoPlayer videoPlayer;
        public bool isOn;

        public void OnScreenPower()
        {
            isOn = !isOn;
            videoPlayer.enabled = isOn;
        }
        */
    }


    public void OnMute()
    {
        isMute = !isMute;
        videoPlayer.SetDirectAudioMute(0, isMute);

        videoPlayer.SetDirectAudioMute(0, !videoPlayer.GetDirectAudioMute(0)); // ������ �Ҹ� ���Ұ�
    }

    /* �ڵ� ���̱�
    public void OnChangeChannel(bool isNext)
    {
        if (isNext)
        {
            clipIndex++;

            if (clipIndex > clips.Length - 1)
            {
                clipIndex = 0;
            }
        }

        else
        {
            clipIndex--;
            if (clipIndex < 0)
            {
                clipIndex = clips.Length - 1;
            }
        }

        videoPlayer.clip = clips[clipIndex];
        videoPlayer.Play();
    }
    */

    public void OnNextChannel() // ������ ��ư 0>1>2
    {
        clipIndex++;
        if (clipIndex > clips.Length - 1)
        {
            clipIndex = 0;
        }

        videoPlayer.clip = clips[clipIndex];
        videoPlayer.Play();
    }

    public void OnPrevChannel() // ���� ��ư 0>2>1
    {
        clipIndex--;
        if (clipIndex < 0)
        {
            clipIndex = clips.Length - 1;
        }

        videoPlayer.clip = clips[clipIndex];
        videoPlayer.Play();
    }
}
