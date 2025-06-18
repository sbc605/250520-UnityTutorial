using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{    
    [SerializeField] private GameObject[] monsters; // ���� ������ �̹� ������ ����

    [SerializeField] private GameObject[] items;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            
            var randomIndex = Random.Range(0, monsters.Length);
            var randomX = Random.Range(-8, 9);
            var randomY = Random.Range(-2.8f, 6);
            var createPos = new Vector3(randomX, randomY, 0);

            Instantiate(monsters[randomIndex], createPos, Quaternion.identity);
        }
    }

    public void DropCoin(Vector3 dropPos)
    {
        var randomIndex = Random.Range(0, items.Length);
        // Instantiate(items[randomIndex], dropPos, Quaternion.identity);

        /// �Ӹ� ���� ���ư���
        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity);
        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>();

        itemRb.AddForceX(Random.Range(-2f, 2f), ForceMode2D.Impulse);
        itemRb.AddForceY(3f, ForceMode2D.Impulse);

        // ������ ȸ�� ��� �߰�
        float ranPower = Random.Range(-1f, 1f);
        itemRb.AddTorque(ranPower, ForceMode2D.Impulse);
    }
}

    /// <summary>
    /// ������ ����� �ʿ��ϸ� ȣ��
    /// </summary>
    ///public void OnSpawnMonster()
    ///{
    ///    StartCoroutine(SpawnRoutine());
    ///}
