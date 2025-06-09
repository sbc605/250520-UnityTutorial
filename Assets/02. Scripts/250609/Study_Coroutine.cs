using UnityEngine;
using System.Collections;

public class Study_Coroutine : MonoBehaviour
{
    private Coroutine runningCoroutine; // �ڷ�ƾ�� ������ ��� ���
    private bool isStop = false;

    /*
    void Start()
    {
        // StartCoroutine("RoutineA");
        runningCoroutine = StartCoroutine(RoutineA());

        StopCoroutine(runningCoroutine);
    }

    IEnumerator RoutineA() // ��⸦ �� �� �ִ� ���
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("�ȳ��ϼ���.");

        yield return new WaitForSeconds(2f);
        Debug.Log("Hello Unity");

        yield return new WaitForSeconds(2f);
        Debug.Log("Coroutine");
    }
    */

    /* IEnumerator Start() // Start��� �̸����� �ڷ�ƾ�� ����� ����ǵ��� (�ڷ�ƾ������ ó�� ���α׷� ����ɶ� ����)
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("1");
    } */

    /* IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f); // �� ������ ����ϱ� ������ ��ǻ�Ͱ� ���� �� ����

            Debug.Log("�ڷ�ƾ ����");
        }    
    }

    private void Update()
    {
        Debug.Log("������Ʈ ����");
    }
    */

    private void Start()
    {
        StartCoroutine(BombRoutine());
    }

    IEnumerator BombRoutine()
    {
        int t = 10;
        while (t > 0)
        {
            Debug.Log($"{t}�� ���ҽ��ϴ�.");
            yield return new WaitForSeconds(1f);
            t--;

            if (isStop)
            {
                Debug.Log("��ź�� �����Ǿ����ϴ�.");
                yield break;
            }
        }
            Debug.Log("��ź�� �������ϴ�.");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

    }
}
