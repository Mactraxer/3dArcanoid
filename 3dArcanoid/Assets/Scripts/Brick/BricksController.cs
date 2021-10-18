using UnityEngine;

public class BricksController : MonoBehaviour
{

    private BrickCreator brickCreator;
    private BrickDestoyControl brickDestoyControl;

    private Brick[,] bricks;
    private int[,] brickMap;

    // Start is called before the first frame update
    public void SetupController()
    {
        brickCreator = GetComponent<BrickCreator>();
        brickDestoyControl = GetComponent<BrickDestoyControl>();
    }

    void Start()
    {
        SetupController();
        brickMap = new int[3, 3];
        bricks = brickCreator.CreateBricksByMap(brickMap, brickDestoyControl.DestroyBrick, brickDestoyControl.BrickCollision);
    }

}
