using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadePanel : MonoBehaviour
{
    /*
     * public Image fadePanel; // ���̵� �̹���

     private float timer = 0f; // ���� Ÿ�̸�
     private float fadeTime = 3f; // ���ϴ� ���̵� �ð�

     private float percent = 0f; // ���� ������� �ø�����

     IEnumerator Start()
     {
         while (percent < 1f)
         {
             timer += Time.deltaTime;
             percent = timer / fadeTime; // ���ϴ� ���̵� �ð��� ���� ����(Fade �ۼ�Ʈ)

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