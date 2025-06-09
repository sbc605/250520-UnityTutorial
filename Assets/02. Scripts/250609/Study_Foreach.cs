using Unity.Collections;
using UnityEngine;

public class Study_Foreach : MonoBehaviour
{
    public string[] persons = new string[5] { "ö��", "����", "����", "����Ŭ", "��" };

    public string findName;

    /*
    void Start()
    {
        int count = 0;
        foreach (string person in persons) // foreach (var p in persons)�� ��.
        {
            count++;

            if (count == 3)
                continue;

            Debug.Log(person);
        }

        ���� ����
        for (int i = 0; i < persons.Length; i++)
        {
            Debug.Log(persons[i]);        
        }

        for (int i = 0; i < 5; i++) �̰� �� ���� but �迭��(�ڸ� �ðų� �ٰų�) ����Ǹ� ������
        */

    private void Start()
    {
        FindPerson(findName);
    }

    private void FindPerson(string name)
    {
        bool isFind = false;
        foreach (var person in persons)
        {
            if (person == name)
            {
                isFind = true;
                Debug.Log($"�ο� �߿� {name}�� �����մϴ�.");
            }
        }

        if (!isFind)
            Debug.Log($"{name}�� ã�� ���߽��ϴ�.");
    }
}
