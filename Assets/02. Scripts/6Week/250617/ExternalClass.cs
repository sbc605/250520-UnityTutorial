using UnityEngine;

public class ExternalClass : MonoBehaviour
{
    public StudyProperty studyProperty;

    /*

    void Start()
    {
        int num1 = studyProperty.Number1; // private 필드에 접근 // 대문자 Number      
        studyProperty.Number1 = 100;

        int num2 = studyProperty.number2; // public 필드에 접근
    } */

    private void Start()
    {
        // studyProperty.moveSpeed = 100f;
    }
}
