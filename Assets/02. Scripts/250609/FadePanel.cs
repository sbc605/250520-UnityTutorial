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

 
    public Image fadePanel; // ���̵� �̹���

    void Start()
    {
        // StartCoroutine(FadeRoutineA(3, true)); // 3�ʵ��� ���̵� �ƿ�

        StartCoroutine(FadeRoutineA(3, false)); // 3�ʵ��� ���̵� ��
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