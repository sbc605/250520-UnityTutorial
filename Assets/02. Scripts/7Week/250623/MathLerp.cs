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
        startPos = transform.position; // ���� ���� ����
    }

    void Update() // ��� �̵���Ű��
    {
        timer += Time.deltaTime; // deltaTime : �ð� ����

        // timer = Time.time; // ����Ƽ �����͸� �÷��� �� ������ ���� �ð�

        percent = timer / lerpTime; // ���� �ð�/���ϴ� �̵� �ð�

        transform.position = Vector3.Lerp(startPos, targetPos, percent);
    }
}
