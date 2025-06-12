using UnityEngine;

public class NumberKeyPad : MonoBehaviour
{
    public Animator doorAnim;
    public GameObject doorLock; // 자식 오브젝트

    public string password; // 비밀번호 설정
    public string keyPadNumber; // 입력한 숫자 (여기에 키입력됨)

    public void OnInputNumber(string numString)
    {
        keyPadNumber += numString;
        // keyPadNumber = keyPadNumber + numString; 글자를 뒤에다 이어붙인다.

        Debug.Log($"{numString} 입력 > 현재 입력 : {keyPadNumber}");
        /* Debug.Log(keyPadNumber.Length); // 입력한 길이
         이런 식으로 글자수 길이도 조절할 수 있음
         */
    }

    public void OnCheckNumber()
    {
        if (keyPadNumber == password)
        {
            Debug.Log("문 열림");
            keyPadNumber = "";

            doorAnim.SetTrigger("Slide Open");
            doorLock.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            Debug.Log("비밀번호 오류");
            keyPadNumber = ""; // 입력값 초기화
        }
    }
}
