using UnityEngine;

public interface IDamageable
{

    void TakeDamage(float damage); // 캐릭터 데미지 구현해야된다
    void Death(); // 파괴 기능
}
