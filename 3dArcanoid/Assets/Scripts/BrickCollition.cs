using UnityEngine;
using UnityEngine.Events;

public class BrickCollition : MonoBehaviour
{
    public UnityEvent<Brick> CollisionAction;
    private Brick brick;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            CollisionAction.Invoke(brick);
        }
    }

    public void SetBrick(Brick brick)
    {
        this.brick = brick;
    }

}
