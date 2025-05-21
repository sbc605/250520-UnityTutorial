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




        //Debug.Log($"정적배열 Array의 첫번째 값 : {arrayNumber[0]}");
        //Debug.Log($"정적배열 Array의 세번째 값 : {arrayNumber[2]}");
        //Debug.Log($"정적배열 Array의 여섯번째 값 : {arrayNumber[5]}");

        //listNumber.Add(1); 
        //listNumber.Add(2); 
        //listNumber.Add(3);
        //listNumber.Add(4);
        //listNumber.Add(5);

        ////lishNumber[0] : 첫번째 데이터
        ////lishNumber[2] : 세번째 데이터

        //                                    // arrayNumber.Length 
        //Debug.Log($"현재 List에 있는 데이터 수 : {listNumber.Count}");
        //Debug.Log($"현재 List의 마지막 데이터 : {listNumber[listNumber.Count - 1]}");

    }
}
