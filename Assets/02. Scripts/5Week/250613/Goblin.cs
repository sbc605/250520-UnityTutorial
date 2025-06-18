using UnityEngine;

public class Goblin : Monster2
{
    public override void Init()
    {
        hp = 3f;
        moveSpeed = 3f;
    }

    public override void Attack()
    {
        Debug.Log("´ë°Å");
    }


}
