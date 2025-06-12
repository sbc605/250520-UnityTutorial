using Unity.Collections;
using UnityEngine;

public class Study_Foreach : MonoBehaviour
{
    public string[] persons = new string[5] { "철수", "영희", "동수", "마이클", "존" };

    public string findName;

    /*
    void Start()
    {
        int count = 0;
        foreach (string person in persons) // foreach (var p in persons)도 됨.
        {
            count++;

            if (count == 3)
                continue;

            Debug.Log(person);
        }

        같은 내용
        for (int i = 0; i < persons.Length; i++)
        {
            Debug.Log(persons[i]);        
        }

        for (int i = 0; i < 5; i++) 이게 더 빠름 but 배열값(자리 늘거나 줄거나) 변경되면 에러남
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
                Debug.Log($"인원 중에 {name}이 존재합니다.");
            }
        }

        if (!isFind)
            Debug.Log($"{name}을 찾지 못했습니다.");
    }
}
