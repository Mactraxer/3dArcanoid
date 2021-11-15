using UnityEngine;

public interface IBrickDelegate
{
    public void AllBricksDestroyed();
    public void BrickDestroyed();
}

[RequireComponent(typeof (BrickCreator))]
[RequireComponent(typeof (BrickDestoyControl))]

public class BricksController : MonoBehaviour
{

    private BrickCreator brickCreator;
    private BrickDestoyControl brickDestoyControl;

    private Brick[,] bricks;
    private int[,] brickMap;

    public int BrickCount;

    public IBrickDelegate brickDelegate;

    private void Start()
    {
        SetupController();
    }

    public void GenerateBricks(int[,] stageMap, IBrickDelegate brickDelegate)
    {
        bricks = brickCreator.CreateBricksByMap(stageMap, DestroyBrick, BrickCollision);
        BrickCount = bricks.GetLength(0) + bricks.GetLength(1);
        this.brickDelegate = brickDelegate;
    }

    private void SetupController()
    {
        brickCreator = GetComponent<BrickCreator>();
        brickDestoyControl = GetComponent<BrickDestoyControl>();
    }

    private void DestroyBrick(Brick brick)
    {
        brickDestoyControl.DestroyBrick(brick);
        BrickCount--;
        if (BrickCount == 0)
        {
            brickDelegate.AllBricksDestroyed();
        }
        else
        {
            brickDelegate.BrickDestroyed();
        }
    }

    private void BrickCollision(Brick brick)
    {
        brickDestoyControl.BrickCollision(brick);
    }


}
