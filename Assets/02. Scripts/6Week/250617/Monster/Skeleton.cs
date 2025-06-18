using UnityEngine;

public class Skeleton : Monster2
{
    public override void Init()
    {
        hp = 10f;
        moveSpeed = 1f;
    }

    public override void Attack()
    {
        Debug.Log("한손검 휘두르기");
    }
}
