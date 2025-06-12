using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    public GameObject videoScreen;
    public Button[] buttonUI;

    private VideoPlayer videoPlayer;

    //  public bool isOn = false; // 스크린 전원 상태(기본 꺼짐)
    public bool isMute = false;

    public VideoClip[] clips;
    public int clipIndex; // 현재 영상 인덱스



    private void Awake()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = clips[0]; // Default 영상 설정
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

        videoScreen.SetActive(!videoScreen.activeSelf); // 오브젝트 상태 기반

        //isOn = !isOn;
        //videoScreen.SetActive(isOn); // 비디오 Active On/Off 기능

        //bool isScreenOn = videoScreen.activeSelf; // Active On인 경우: true // Active 상태 판별 기능


        /* 원래 쓴 코드
        if (!isOn)
        {
            videoScreen.SetActive(true);
            isOn = true; // 현재 티비 On

        }
        else // (isOn == true)
        {
            videoScreen.SetActive(false);
            isOn = false;
        } */
        /* 숏코드
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

        videoPlayer.SetDirectAudioMute(0, !videoPlayer.GetDirectAudioMute(0)); // 영상의 소리 음소거
    }

    /* 코드 줄이기
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

    public void OnNextChannel() // 오른쪽 버튼 0>1>2
    {
        clipIndex++;
        if (clipIndex > clips.Length - 1)
        {
            clipIndex = 0;
        }

        videoPlayer.clip = clips[clipIndex];
        videoPlayer.Play();
    }

    public void OnPrevChannel() // 왼쪽 버튼 0>2>1
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
