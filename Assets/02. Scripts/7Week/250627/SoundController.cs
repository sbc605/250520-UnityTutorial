using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioSource bgmAudio;
    [SerializeField] private AudioSource eventAudio;

    [SerializeField] private AudioClip[] clips;

    [SerializeField] private Slider bgmVolume, eventVolume;
    [SerializeField] private Toggle bgmMute, eventMute;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        bgmVolume.value = bgmAudio.volume;
        eventVolume.value = eventAudio.volume;

        bgmMute.isOn = bgmAudio.mute;
        eventMute.isOn = eventAudio.mute;
    }

    void Start()
    {
        //bgmAudio = GetComponent<AudioSource>();

        BgmSoundPlay("Town");

        bgmVolume.onValueChanged.AddListener(OnBGMVolumeChanged);
        eventVolume.onValueChanged.AddListener(OnEventVolumeChanged);

        bgmMute.onValueChanged.AddListener(OnBgmMute);
        eventMute.onValueChanged.AddListener(OnEventMute);
    }

    public void BgmSoundPlay(string clipName)
    {
        foreach (var clip in clips)
        {
            if (clip.name == clipName)
            {
                bgmAudio.Stop();
                bgmAudio.clip = clip;
                bgmAudio.Play();

                return;
            }
        }

        Debug.Log($"{clipName}�� ã�� ���߽��ϴ�.");
    }

    public void EventSoundPlay(string clipName)
    {
        foreach (var clip in clips)
        {
            if (clip.name == clipName)
            {
                eventAudio.PlayOneShot(clip);

                return;
            }
        }

        Debug.Log($"{clipName}�� ã�� ���߽��ϴ�.");
    }

    private void OnBGMVolumeChanged(float volume)
    {
        bgmAudio.volume = volume;
    }

    private void OnEventVolumeChanged(float volume)
    {
        eventAudio.volume = volume;
    }

    private void OnBgmMute(bool isMute)
    {
        bgmAudio.mute = isMute;
    }

    private void OnEventMute(bool isMute)
    {
        eventAudio.mute = isMute;
    }
}
