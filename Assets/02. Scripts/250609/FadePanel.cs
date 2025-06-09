using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadePanel : MonoBehaviour
{
    /*
     * public Image fadePanel; // 페이드 이미지

     private float timer = 0f; // 사용될 타이머
     private float fadeTime = 3f; // 원하는 페이드 시간

     private float percent = 0f; // 비율 기반으로 올릴거임

     IEnumerator Start()
     {
         while (percent < 1f)
         {
             timer += Time.deltaTime;
             percent = timer / fadeTime; // 원하는 페이드 시간에 따른 비율(Fade 퍼센트)

             fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 1 - percent);
             yield return null;
         }
     }
    */

 
    public Image fadePanel; // 페이드 이미지

    void Start()
    {
        // StartCoroutine(FadeRoutineA(3, true)); // 3초동안 페이드 아웃

        StartCoroutine(FadeRoutineA(3, false)); // 3초동안 페이드 인
    }

    IEnumerator FadeRoutineA(float fadeTime, bool isFadeIn)
    {
        float timer = 0f;
        float percent = 0f;
        float value = 0f;
        while (percent < 1f)
        {
            timer += Time.deltaTime;
            percent = timer / fadeTime;
            value = isFadeIn ? percent : 1 - percent;

            fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, value);
            yield return null;
        }
    }
}