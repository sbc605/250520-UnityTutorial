using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Monster : MonoBehaviour, IDamageable
{
    /* 생성자 예시
    public string name;
    public float damage;
    public float hp;

    public Monster()
    {
        this.name = "슬라임";
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

    // Monster 클래스의 생성자
    public Monster(string name, float damage, float hp)
    {
        this.name = name;
        this.damage = damage;
        this.hp = hp;
    }


    void Start()
    {
        Monster m1 = new Monster(); // 이건 이름 슬라임 나옴
        Monster m2 = new Monster("슬라임킹");
        Monster m3 = new Monster("슬라임킹", 3f);
        Monster m4 = new Monster("고블린", 2f, 3f);
    } */

    /* 오버라이드 예시
    public override void Attack()
    {
        Debug.Log("Monster 공격");
    }

    public override void Move()
    {
        Debug.Log("Monster 이동");
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
        Debug.Log("몬스터 다운");
    }
}


