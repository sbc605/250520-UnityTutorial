using System;
using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    int number = 1;
    private int number2 = 2;
    public int number3 = 3;

    [SerializeField]
    private int number4 = 4;

    [SerializeField] private int number5 = 5;


    //int[] arrayNumber = new int[5] {1, 2, 3, 4, 5};

    //public List<int> listNumber = new List<int>();

    void Start()
    {




        //Debug.Log($"�����迭 Array�� ù��° �� : {arrayNumber[0]}");
        //Debug.Log($"�����迭 Array�� ����° �� : {arrayNumber[2]}");
        //Debug.Log($"�����迭 Array�� ������° �� : {arrayNumber[5]}");

        //listNumber.Add(1); 
        //listNumber.Add(2); 
        //listNumber.Add(3);
        //listNumber.Add(4);
        //listNumber.Add(5);

        ////lishNumber[0] : ù��° ������
        ////lishNumber[2] : ����° ������

        //                                    // arrayNumber.Length 
        //Debug.Log($"���� List�� �ִ� ������ �� : {listNumber.Count}");
        //Debug.Log($"���� List�� ������ ������ : {listNumber[listNumber.Count - 1]}");

    }
}
