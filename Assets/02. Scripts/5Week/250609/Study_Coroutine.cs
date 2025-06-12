using UnityEngine;
using System.Collections;

public class Study_Coroutine : MonoBehaviour
{
    private Coroutine runningCoroutine; // 코루틴을 변수에 담아 사용
    private bool isStop = false;

    /*
    void Start()
    {
        // StartCoroutine("RoutineA");
        runningCoroutine = StartCoroutine(RoutineA());

        StopCoroutine(runningCoroutine);
    }

    IEnumerator RoutineA() // 대기를 할 수 있는 기능
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("안녕하세요.");

        yield return new WaitForSeconds(2f);
        Debug.Log("Hello Unity");

        yield return new WaitForSeconds(2f);
        Debug.Log("Coroutine");
    }
    */

    /* IEnumerator Start() // Start라는 이름으로 코루틴을 만들면 실행되도록 (코루틴이지만 처음 프로그램 실행될때 실행)
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("1");
    } */

    /* IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f); // 한 프레임 대기하기 때문에 컴퓨터가 부하 덜 받음

            Debug.Log("코루틴 실행");
        }    
    }

    private void Update()
    {
        Debug.Log("업데이트 실행");
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
            Debug.Log($"{t}초 남았습니다.");
            yield return new WaitForSeconds(1f);
            t--;

            if (isStop)
            {
                Debug.Log("폭탄이 해제되었습니다.");
                yield break;
            }
        }
            Debug.Log("폭탄이 터졌습니다.");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

    }
}
