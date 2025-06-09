using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playTimeUI;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        // playTimeUI.text = timer.ToString(); // 숫자형 타입을 string으로 형 변환
        playTimeUI.text = string.Format("플레이 시간 : {0:F0}초", timer);
    }
}
