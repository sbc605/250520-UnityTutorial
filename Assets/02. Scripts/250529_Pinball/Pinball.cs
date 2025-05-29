using UnityEngine;

public class Pinball : MonoBehaviour

{

    public PinballManager pinballManager; // ����Ƽ�󿡼� �Ҵ� �ʿ�

    // void Start()
    // {
    //    FindObjectOfType<PinballManager>();
    // }


    void OnCollisionEnter2D(Collision2D other)

    {
    //    if (other.gameObject.CompareTag("Untagged"))
    //        return;

        int score = 0;

        switch (other.gameObject.tag)
        {
            case "Score10":
                score = 10;
                break;
            case "Score30":
                score = 30;
                break;
            case "Score50":
                score = 50;
                break;
        }

        pinballManager.totalScore += score;

        if (score != 0)
        Debug.Log($"{score}�� ȹ��");

        /*
         * if (other.gameObject.CompareTag("Score10"))
        {
            pinballManager.totalScore += 10;
            Debug.Log("10�� ȹ��");
        }

        else if (other.gameObject.CompareTag("Score30"))
        {
            pinballManager.totalScore += 30;
            Debug.Log("30�� ȹ��");
        }

        else if (other.gameObject.CompareTag("Score50"))
        {
            pinballManager.totalScore += 50;
            Debug.Log("50�� ȹ��");
        }
        */
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GameOver"))
        {
            Debug.Log($"���� ���� : ���� ���� {pinballManager.totalScore}");
        }
    }

}
