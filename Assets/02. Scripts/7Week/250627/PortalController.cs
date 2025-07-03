using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PortalController : MonoBehaviour
{
    public enum SceneType { TOWN, ADVENTURE }
    public SceneType sceneType;

    public GameObject portalEffect;
    public GameObject loadingImage;
    public FadeRoutine fade;
    public Image progressBar;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PortalEvent());
        }
    }

    IEnumerator PortalEvent()
    {
        portalEffect.SetActive(true);

        yield return StartCoroutine(fade.Fade(2f, Color.white, true));

        loadingImage.SetActive(true);
        yield return StartCoroutine(fade.Fade(2f, Color.white, false));

        while (progressBar.fillAmount < 1f)
        {
            progressBar.fillAmount += Time.deltaTime * 0.3f; // 1초만에 되는 걸 3초정도 걸리도록 만든 것

            yield return null;
        }

        if (sceneType == SceneType.TOWN)
        {
            SceneManager.LoadScene(1);
        }

        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
