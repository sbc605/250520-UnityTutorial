using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    private int count = 0;

    void Start()
    {
        /* while��
        while (count < 10) // �ݺ��� 10���� ����
        {
            count++;
            Debug.Log($"���� {count}�Դϴ�.");
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
        

        // while�� �̿��� 3.6.9 ����
          while (count < 10)
        {
            count++;

            // 3�� ��� ����
            if(count % 3 == 0) // count�� 3���� ������ ��, ���� 0�� ������ ���
            {
                Debug.Log("�ڼ� ¦!");
                continue;
            }

            Debug.Log(count);
        }
        

        /* do_while��
         * do
        {
            Debug.Log($"���� {count}�Դϴ�.");
            count++;
        } while (count < 7);
        */
    }
}


