using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Movement2.coinCount++;

            Debug.Log($"������� {Movement2.coinCount}���� ���� ȹ��!!");

            Destroy(this.gameObject);
        }
    }

}
