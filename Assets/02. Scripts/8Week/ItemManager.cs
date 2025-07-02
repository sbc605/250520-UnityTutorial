using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private GameObject[] items;

    public void DropItem(Vector3 dropPos)
    {
        var randomIndex = Random.Range(0, items.Length); // 랜덤 아이템 선택

        /// 머리 위로 날아가게
        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity); // 선택된 아이템 생성

        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>(); // 랜덤 파워/방향으로 뿌리기

        itemRb.AddForceX(Random.Range(-2f, 2f), ForceMode2D.Impulse);
        itemRb.AddForceY(3f, ForceMode2D.Impulse);
        // 통합 사용: itemRb.AddForce(new Vector2(Random.Range(-2f,2f), 3f), ForceMode2D.Impulse);

        // 아이템 회전 기능 추가
        float ranPower = Random.Range(-1f, 1f);
        itemRb.AddTorque(ranPower, ForceMode2D.Impulse);
    }

    public void GetItem(IItemObject item)
    {

    }
}
