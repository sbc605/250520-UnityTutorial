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

        Vector3 vec = new Vector3(10, 20, 30); // �Ű������� �� �������� ���ڷ� ���� ��
                                               // (Vecotr�ȿ� �� ���� float) but ������ f���̱� �������� �˾Ƽ� ����ȯ���ִ°�(�Ͻ��� ����ȯ)
        Vector3Int vecInt = new Vector3Int(10, 20, 30);       
    } */

    
    /* int number1 = 1;
    float number2 = 1.23f;

    private void Start()
    {
        number1 = (int)number2;
        Debug.Log(number1);

        // �������� ���
        float number4 = Mathf.Floor(number2); // ����
        float number5 = Mathf.Ceil(number2); // �ø�
        float number6 = Mathf.Round(number2); // �ݿø� ( x <= 5)

        Debug.Log($"Floor �������� : {number4}");
        Debug.Log($"Ceil �ø����� : {number5}");
        Debug.Log($"Round �ݿø� : {number6}");
    }*/

    /* Parse Ȱ��
    private void Start()
    {
        string str1 = "123";
        string str2 = "456";

        string str3 = str1 + str2; // 579���� �ƴ϶� 123456���� ����(���ڰ� �ƴ϶� �۾�)(����ƴ�)
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
         string str1 = "�ȳ��ϼ���";

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
    // ����Ʈ Ʈ�� = new ����Ʈ
    // ����Ʈ ������ = new ����Ʈ
    // ����Ʈ ũ���� = new ����Ʈ

    List<Monster> monsters = new List<Monster>();

    private void Start()
    {
        //Orc o = new Orc();
        //Goblin g = new Goblin();

        //// �ٿ� ĳ����
        //Monster m5 = new Monster();
        //Orc o2 = (Orc) m5;
        //Debug.Log(02);


        /* �� ĳ����
        // ����� ����ȯ
        Monster m1 = (Monster)o;
        Monster m2 = (Monster)g;

        // �Ͻ��� ����ȯ
        Monster m3 = o;
        Monster m4 = g;

        monsters.Add(o);
        monsters.Add(g);
        */

        /// ��ü ����
        /// monster.AllAttack();


        /// ��ü ����
        /// orcs.AllAttack();
        /// goblins.AllAttack();
        /// Ʈ��.AllAttack();
        /// ������.AllAttack();
        /// ũ����.AllAttack();


        // Monster m = new Monster();
        // Orc o = m; // �̷��� ������ �Ͻ��� ����ȯ �����ʾƼ� ����
        // Orc o = (Orc)m; // ����� ����ȯ > ����

        /* Orc o = m as Orc; // ������ ����ȯ, ���н� null

        if (o != null)
            Debug.Log(o);

        else // if (o == null)
            Debug.Log("����ȯ ���� ����"); // null �� */
    }
}
