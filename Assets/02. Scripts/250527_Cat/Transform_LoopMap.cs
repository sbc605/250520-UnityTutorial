using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Vector3 returnPos = new Vector3(30f, 1.5f, 0f);

    void Update()
    {
        // ��� �������� �̵��ϴ� ���
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;
        Debug.Log(Time.fixedDeltaTime);

        if (transform.position.x <= -30f) // �̹����� x�� ���� -30�� �Ѵ� ����
        {
            transform.position = returnPos; // ���� ���� ������ x=30���� �ʱ�ȭ
        }
    }
}
