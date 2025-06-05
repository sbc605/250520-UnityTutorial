using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    private int count = 0;

    void Start()
    {
        /* while문
        while (count < 10) // 반복문 10번만 실행
        {
            count++;
            Debug.Log($"현재 {count}입니다.");
        }
        */

        /* break
        while (count < 10)
        {
            count++;
            Debug.Log(count);

            if(count == 5)
            {
                break;
            }
        } */
        

        /* continue
        while (count < 10)
        {
            count++;
            
            if (count == 5)
            {
                continue;
            }

            Debug.Log(count);
        } */
        

        // while을 이용한 3.6.9 게임
          while (count < 10)
        {
            count++;

            // 3의 배수 조건
            if(count % 3 == 0) // count를 3으로 나눴을 때, 값이 0이 나오는 경우
            {
                Debug.Log("박수 짝!");
                continue;
            }

            Debug.Log(count);
        }
        

        /* do_while문
         * do
        {
            Debug.Log($"현재 {count}입니다.");
            count++;
        } while (count < 7);
        */
    }
}


