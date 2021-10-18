using System;
using UnityEngine;
public class Brick
{
    private int durability;
    public delegate void DethAction(Brick brick);
    private DethAction onDeth;
    public GameObject gameObject { get; }

    public Brick(int durability, GameObject brick, DethAction dethAction)
    {
        this.durability = durability;
        onDeth = dethAction;
        gameObject = brick;
    }

    public void ApplyDamage(int value)
    {
        durability -= value;
        if (durability < 1)
        {
            onDeth(this);
        }
    }
}
