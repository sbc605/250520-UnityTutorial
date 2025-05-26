using UnityEngine;

public class SutdyOperator : MonoBehaviour
{

    public int currentLevel = 10;
    public int maxLevel = 99;

    void Start()
    {
       // 비교 연산에 의한 결과를 bool 값으로 받는 코드
       // bool isMax = currentLevel >= maxLevel;

        //Debug.Log($"현재 레벨은 만렙이 {isMax}입니다.");
        // Debug.Log($"현재 레벨은 만렙이 {currentLevel >= maxLevel}입니다."); 로 해도 됨

        
        string msg = currentLevel >= maxLevel ? "현재 만렙입니다." : "현재 만렙이 아닙니다.";

        Debug.Log(msg);

        //        if (currentLevel >= maxLevel)
        //        {
        //            string msg = "현재 만렙입니다."
        //        }
        //        else
        //        {
        //            string msg = "현재 만렙이 아닙니다."
        //        }

        //int levelPoint = currentLevel >= maxLevel ? 0 : 1;
        //currentLevel += levelPoint;

    }

}
