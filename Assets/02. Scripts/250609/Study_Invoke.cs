using UnityEngine;

public class Study_Invoke : MonoBehaviour
{
    public float timer = 5f;

    void Start()
    {
        // Invoke("Method1", timer); // Destroy(게임오브젝트, 5f);

        // CancelInvoke("Method1");

        // 반복 Invoke ("함수명", 처음 지연시간, 몇초마다 실행)
        InvokeRepeating("Method1", 3f, 1f);
    }

    void Method1()
    {
        Debug.Log("Invoke 메서드 실행");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("Method1");
        }
    }
}
