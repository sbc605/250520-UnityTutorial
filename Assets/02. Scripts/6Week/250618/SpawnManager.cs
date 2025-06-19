using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{    
    [SerializeField] private GameObject[] monsters; // 몬스터 종류가 이미 정해진 상태

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
                        
            GameObject monsterObj = Instantiate(monsters[randomIndex], createPos, Quaternion.identity);

            int ranDir = Random.Range(0, 2) > 0 ? 1 : -1;

            monsterObj.GetComponent<Monster2>().Dir = ranDir;
            monsterObj.GetComponent<Monster2>().SetFlip(ranDir);
        }
    }

    public void DropCoin(Vector3 dropPos)
    {
        var randomIndex = Random.Range(0, items.Length);

        /// 머리 위로 날아가게
        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity);
        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>();

        itemRb.AddForceX(Random.Range(-2f, 2f), ForceMode2D.Impulse);
        itemRb.AddForceY(3f, ForceMode2D.Impulse);
        // 통합 사용: itemRb.AddForce(new Vector2(Random.Range(-2f,2f), 3f), ForceMode2D.Impulse);

        // 아이템 회전 기능 추가
        float ranPower = Random.Range(-1f, 1f);
        itemRb.AddTorque(ranPower, ForceMode2D.Impulse);
    }
}
