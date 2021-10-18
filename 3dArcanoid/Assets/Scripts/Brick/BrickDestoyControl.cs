using UnityEngine;

public class BrickDestoyControl : MonoBehaviour
{
    public void BrickCollision(Brick brick)
    {
        brick.ApplyDamage(3);
    }

    public void DestroyBrick(Brick brick)
    {
        Destroy(brick.gameObject);
    }

}
