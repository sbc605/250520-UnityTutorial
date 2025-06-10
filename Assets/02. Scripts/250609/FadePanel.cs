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

 
    public Image fadePanel;


    public void OnFade(float fadeTime, Color color)
    {
        StartCoroutine(Fade(fadeTime, color));
    }

    IEnumerator Fade(float fadeTime, Color color)
    {
        float timer = 0f;
        float percent = 0f;
        while (percent < 1f)
        {
            timer += Time.deltaTime;
            percent = timer / fadeTime;

            fadePanel.color = new Color(color.r, color.g, color.b, percent);
            yield return null;
        }
    }
}