using UnityEngine;

public class Character : MonoBehaviour
{
    /* public float hp;
    public float moveSpeed;

    public void Move()
    {
        Debug.Log("이동");
    }


    public virtual void Attack()
    {
        Debug.Log("공격");
    }

    public abstract void Hit();
    */

    /* private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flash Light"))
        {
            other.GetComponent<FlashLight>().FlashOn();
        }
        else if (other.CompareTag("Gun"))
        {
            other.GetComponent<Gun>().Shoot();
        }
    } */

    public IDropItem currentItem;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentItem.Use();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            currentItem.Drop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IDropItem>() != null) // 감지된 대상에 IDropItem이 있다면
        {
            IDropItem item = other.GetComponent<IDropItem>(); // 지역변수 생성

            item.Grab(); // 아이템 획득

            currentItem = item; // 현재 아이템 장착
        }
    }
}

