using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Video;

namespace cat
{
    public class VideoManager : MonoBehaviour
    {
        public VideoPlayer vPlayer;
        public GameObject videoPanel;
        public VideoClip[] vClips;

        private void Start()
        {
            vPlayer = GetComponent<VideoPlayer>();
        }

        public void VideoPlay(bool isHappy)
        {
            videoPanel.SetActive(true); // �����г� ��

            var endingClip = isHappy ? vClips[0] : vClips[1]; // isHappy�� bool��
            vPlayer.clip = endingClip;
            vPlayer.Play();
        }
    }
}
