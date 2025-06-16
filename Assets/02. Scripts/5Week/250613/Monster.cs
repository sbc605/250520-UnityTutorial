using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Monster : MonoBehaviour, IDamageable
{
    /* ������ ����
    public string name;
    public float damage;
    public float hp;

    public Monster()
    {
        this.name = "������";
        this.damage = 1;
        this.hp = 1;
    }

    public Monster(string name)
    {
        this.name = name;
        this.damage = 1;
        this.hp = 1;
    }

    public Monster(string name, float damage)
    {
        this.name = name;
        this.damage = damage;
        this.hp = 1;
    }

    // Monster Ŭ������ ������
    public Monster(string name, float damage, float hp)
    {
        this.name = name;
        this.damage = damage;
        this.hp = hp;
    }


    void Start()
    {
        Monster m1 = new Monster(); // �̰� �̸� ������ ����
        Monster m2 = new Monster("������ŷ");
        Monster m3 = new Monster("������ŷ", 3f);
        Monster m4 = new Monster("���", 2f, 3f);
    } */

    /* �������̵� ����
    public override void Attack()
    {
        Debug.Log("Monster ����");
    }

    public override void Move()
    {
        Debug.Log("Monster �̵�");
    } */

    public float hp;
    public abstract void SetHealth();

    void Start()
    {
        SetHealth();
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0f)
        {
            Death();
        }
    }

    public void Death()
    {
        Debug.Log("���� �ٿ�");
    }
}


