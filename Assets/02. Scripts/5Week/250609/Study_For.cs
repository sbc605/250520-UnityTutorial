using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Study_For : MonoBehaviour
{
    /* for�� �⺻
     * void Start()
    {
        for (int i = 0; i < 10; i++) // start , ���� ����(0~9), ���� ����
        {
            Debug.Log(i);
        }
    }
    */

    /* Array Length
     * public int[] arrayInt = new int[5]; // int[] �迭(�������� i), �̸��� arrayInt, 5ĭ ����

    private void Start()
    {
        for (int i = 0; i < arrayInt.Length; i++) // �� i�� �� ��� ��(�̸���)
            // i��� �̸��� �������� ����, i <5 ���� ����, ��������
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

    // ���� �ݺ���
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
