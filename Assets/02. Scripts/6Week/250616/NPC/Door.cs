using UnityEngine;

public class Door : MonoBehaviour, IDamageable
{
    public float hp = 100f;

    // IDamageable�� �־ ���� ����
    public void TakeDamage(float damage)
    {
        Debug.Log($"{damage}��ŭ�� ���ظ� �Ծ����ϴ�.");

        hp -= damage;
        if (hp <= 0f)
        {
            Death();
        }
    }

    public void Death()
    {
        Debug.Log("���� �ı��Ǿ����ϴ�.");
    }
}
