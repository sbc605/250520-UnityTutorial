using UnityEngine;

public class SutdyOperator : MonoBehaviour
{

    public int currentLevel = 10;
    public int maxLevel = 99;

    void Start()
    {
       // �� ���꿡 ���� ����� bool ������ �޴� �ڵ�
       // bool isMax = currentLevel >= maxLevel;

        //Debug.Log($"���� ������ ������ {isMax}�Դϴ�.");
        // Debug.Log($"���� ������ ������ {currentLevel >= maxLevel}�Դϴ�."); �� �ص� ��

        
        string msg = currentLevel >= maxLevel ? "���� �����Դϴ�." : "���� ������ �ƴմϴ�.";

        Debug.Log(msg);

        //        if (currentLevel >= maxLevel)
        //        {
        //            string msg = "���� �����Դϴ�."
        //        }
        //        else
        //        {
        //            string msg = "���� ������ �ƴմϴ�."
        //        }

        //int levelPoint = currentLevel >= maxLevel ? 0 : 1;
        //currentLevel += levelPoint;

    }

}
