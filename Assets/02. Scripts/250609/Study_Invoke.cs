using UnityEngine;

public class Study_Invoke : MonoBehaviour
{
    public float timer = 5f;

    void Start()
    {
        // Invoke("Method1", timer); // Destroy(���ӿ�����Ʈ, 5f);

        // CancelInvoke("Method1");

        // �ݺ� Invoke ("�Լ���", ó�� �����ð�, ���ʸ��� ����)
        InvokeRepeating("Method1", 3f, 1f);
    }

    void Method1()
    {
        Debug.Log("Invoke �޼��� ����");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("Method1");
        }
    }
}
