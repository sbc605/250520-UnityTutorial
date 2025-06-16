using UnityEngine;
using System;
using System.Collections.Generic;
using JetBrains.Annotations;

public class Study_Casting : MonoBehaviour
{
    /* int number1 = 1;
    float number2 = 10.5f;

    void Start()
    {
        number1 = (int)number2;
        Debug.Log(number1);

        Vector3 vec = new Vector3(10, 20, 30); // 매개변수를 딱 떨어지는 숫자로 넣은 것
                                               // (Vecotr안에 들어간 값은 float) but 일일이 f붙이기 귀찮은데 알아서 형변환해주는것(암시적 형변환)
        Vector3Int vecInt = new Vector3Int(10, 20, 30);       
    } */

    
    /* int number1 = 1;
    float number2 = 1.23f;

    private void Start()
    {
        number1 = (int)number2;
        Debug.Log(number1);

        // 수학적인 기능
        float number4 = Mathf.Floor(number2); // 내림
        float number5 = Mathf.Ceil(number2); // 올림
        float number6 = Mathf.Round(number2); // 반올림 ( x <= 5)

        Debug.Log($"Floor 내림차순 : {number4}");
        Debug.Log($"Ceil 올림차순 : {number5}");
        Debug.Log($"Round 반올림 : {number6}");
    }*/

    /* Parse 활용
    private void Start()
    {
        string str1 = "123";
        string str2 = "456";

        string str3 = str1 + str2; // 579값이 아니라 123456으로 나옴(숫자가 아니라 글씨)(연산아님)
        //Debug.Log("String : " + str3);// 123456

        int num1 = int.Parse(str1);
        int num2 = int.Parse(str2);        

        //Debug.Log("String : " + num1 + num2); // 123456

        int num3 = num1 + num2; 

        Debug.Log("Int : " + num3); // 579
        
        //Debug.Log("Int : " + (num1 + num2)); // 579
        //Debug.Log($"Int : {num1} + {num2}"); // 123 + 456
    } */

    /* private void Start()
     {
         int num0 = 0;
         int num1 = 1;
         int num2 = 2;
         int num100 = 100;

         float fNum0 = 0f;
         float fNum1 = 1.57f;
         float fNum2 = 3.14f;

         string str2 = "true";
         string str3 = "false";       
         string str1 = "안녕하세요";

         Debug.Log("Num0 : " + Convert.ToBoolean(num0));
         Debug.Log("Num1 : " + Convert.ToBoolean(num1));
         Debug.Log("Num2 : " + Convert.ToBoolean(num2));
         Debug.Log("Num100 : " + Convert.ToBoolean(num100));

         Debug.Log("fNum0 : " + Convert.ToBoolean(fNum0));
         Debug.Log("fNum1 : " + Convert.ToBoolean(fNum1));
         Debug.Log("fNum2 : " + Convert.ToBoolean(fNum2));

         Debug.Log("str2 : " + Convert.ToBoolean(str2));
         Debug.Log("str3 : " + Convert.ToBoolean(str3));
         Debug.Log("str1 : " + Convert.ToBoolean(str1));


     } */

    /* ToInt
     private void Start()
    {
        bool isBool1 = true;
        bool isBool2 = false;

        int num1 = Convert.ToInt32(isBool1); // 1
        int num2 = Convert.ToInt32(isBool2); // 0

        Debug.Log(num1);
        Debug.Log(num2);
    } */

    //List<Orc> orcs = new List<Orc>();
    //List<Goblin> goblins = new List<Goblin>();
    // 리스트 트롤 = new 리스트
    // 리스트 가고일 = new 리스트
    // 리스트 크라켄 = new 리스트

    List<Monster> monsters = new List<Monster>();

    private void Start()
    {
        //Orc o = new Orc();
        //Goblin g = new Goblin();

        //// 다운 캐스팅
        //Monster m5 = new Monster();
        //Orc o2 = (Orc) m5;
        //Debug.Log(02);


        /* 업 캐스팅
        // 명시적 형변환
        Monster m1 = (Monster)o;
        Monster m2 = (Monster)g;

        // 암시적 형변환
        Monster m3 = o;
        Monster m4 = g;

        monsters.Add(o);
        monsters.Add(g);
        */

        /// 전체 공격
        /// monster.AllAttack();


        /// 전체 공격
        /// orcs.AllAttack();
        /// goblins.AllAttack();
        /// 트롤.AllAttack();
        /// 가고일.AllAttack();
        /// 크라켄.AllAttack();


        // Monster m = new Monster();
        // Orc o = m; // 이렇게 적으면 암시적 형변환 되지않아서 에러
        // Orc o = (Orc)m; // 명시적 형변환 > 에러

        /* Orc o = m as Orc; // 성공시 형변환, 실패시 null

        if (o != null)
            Debug.Log(o);

        else // if (o == null)
            Debug.Log("형변환 되지 않음"); // null 뜸 */
    }
}
