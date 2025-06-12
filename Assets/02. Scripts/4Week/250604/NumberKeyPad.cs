using UnityEngine;

public class NumberKeyPad : MonoBehaviour
{
    public Animator doorAnim;
    public GameObject doorLock; // �ڽ� ������Ʈ

    public string password; // ��й�ȣ ����
    public string keyPadNumber; // �Է��� ���� (���⿡ Ű�Էµ�)

    public void OnInputNumber(string numString)
    {
        keyPadNumber += numString;
        // keyPadNumber = keyPadNumber + numString; ���ڸ� �ڿ��� �̾���δ�.

        Debug.Log($"{numString} �Է� > ���� �Է� : {keyPadNumber}");
        /* Debug.Log(keyPadNumber.Length); // �Է��� ����
         �̷� ������ ���ڼ� ���̵� ������ �� ����
         */
    }

    public void OnCheckNumber()
    {
        if (keyPadNumber == password)
        {
            Debug.Log("�� ����");
            keyPadNumber = "";

            doorAnim.SetTrigger("Slide Open");
            doorLock.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            Debug.Log("��й�ȣ ����");
            keyPadNumber = ""; // �Է°� �ʱ�ȭ
        }
    }
}
