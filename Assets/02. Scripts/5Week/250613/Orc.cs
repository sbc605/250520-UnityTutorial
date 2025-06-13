using UnityEngine;

public class Orc : Monster
{
    void Start()
    {
        Monster monster = new Orc();
        Orc orc = monster as Orc; // 성공시 형변환, 실패시 null

        if (orc != null)
            Debug.Log(orc);

        else // if (o == null)
            Debug.Log("형변환 되지 않음"); // 로그로 뜸
    }

}
