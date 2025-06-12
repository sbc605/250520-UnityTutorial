using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Study_For : MonoBehaviour
{
    /* for문 기본
     * void Start()
    {
        for (int i = 0; i < 10; i++) // start , 범위 조건(0~9), 증감 단위
        {
            Debug.Log(i);
        }
    }
    */

    /* Array Length
     * public int[] arrayInt = new int[5]; // int[] 배열(지역변수 i), 이름은 arrayInt, 5칸 생성

    private void Start()
    {
        for (int i = 0; i < arrayInt.Length; i++) // 꼭 i라 안 적어도 됨(이름임)
            // i라는 이름의 지역변수 설정, i <5 범위 조건, 증감연산
        {
            Debug.Log(arrayInt[i]);
        }
    }
    */

    /* List Count
    public List<int> listInt = new List<int>();

    private void Start()
    {
        for (int i = 0; i < listInt.Count; i++)
        {
            Debug.Log(listInt[i]);
        }
    }
    */

    // 이중 반복문
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log($"{i} / {j}");
            }
        }
    }
}
