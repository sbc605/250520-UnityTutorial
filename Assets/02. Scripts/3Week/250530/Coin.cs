using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Movement2.coinCount++;

            Debug.Log($"현재까지 {Movement2.coinCount}개의 코인 획득!!");

            Destroy(this.gameObject);
        }
    }

}
