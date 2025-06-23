using UnityEngine;

public class MathLerp : MonoBehaviour
{
    public Vector3 targetPos;
    public float smoothValue;

    private Vector3 startPos;
    private float timer, percent;
    public float lerpTime;

    void Start()
    {
        startPos = transform.position; // 시작 지점 저장
    }

    void Update() // 대상 이동시키기
    {
        timer += Time.deltaTime; // deltaTime : 시간 조각

        // timer = Time.time; // 유니티 에디터를 플레이 한 이후의 누적 시간

        percent = timer / lerpTime; // 현재 시간/원하는 이동 시간

        transform.position = Vector3.Lerp(startPos, targetPos, percent);
    }
}
