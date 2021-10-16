using System;
class Brick
{
    private int durability;
    public delegate void DethAction();
    private DethAction onDeth;

    public Brick(int durability, DethAction dethAction)
    {
        this.durability = durability;
        onDeth = dethAction;
    }

    public void ApplyDamage(int value)
    {
        durability -= value;
        if (durability < 1)
        {
            onDeth();
        }
    }
}
