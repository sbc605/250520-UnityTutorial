using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;

    public bool isStop;
    public bool isRotating;

    private void Start()
    {
        rotSpeed = 0f;
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed); // z�� �������� ȸ���ϴ� ���
        //transform.Rotate(0f, 0f, rotSpeed);

        // ���콺 ���� ��ư�� ������ �� > 1�� ����
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 5;
            isRotating = true; // �귿�� ���� ��
        }

        // Ű���� �����̽� ��ư�� ������ �� > 1�� ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isRotating) // ���� ���� �ִٸ�
            
                isStop = true; // ���� ����
             
            
        }

        if (isStop == true)
        {
            rotSpeed *= 0.98f; // ���� �ӵ����� Ư�� ����ŭ ���̴� ���

            if (rotSpeed <= 0.01f)
            {
                rotSpeed = 0f;
                isStop = false;
                isRotating = false;
            }
        }
    }
}
