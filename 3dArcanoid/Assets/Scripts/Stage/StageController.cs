using UnityEngine;

public class StageController : MonoBehaviour
{
    private StageCreator stageCreator;
    private ArrayMap mapConvertor;

    private BrickCreator brickCreator;
    private BrickDestoyControl brickDestoyControl;

    private Brick[,] bricks;
    private int[,] brickMap;

    private int[,] stageMap;


    // Start is called before the first frame update
    void Start()
    {
        SetupController();
        GenerateMap();   
    }

    private void GenerateMap()
    {
        stageMap = mapConvertor.ConvertSpriteToArrayMap();
        GenerateStage();
    }

    private void GenerateStage()
    {
        stageCreator = GetComponent<StageCreator>();
        stageCreator.CreateStageByMap(stageMap);
        GenerateBricks();
    }

    private void GenerateBricks()
    {
        bricks = brickCreator.CreateBricksByMap(stageMap, brickDestoyControl.DestroyBrick, brickDestoyControl.BrickCollision);
    }

    public void SetupController()
    {
        brickCreator = GetComponent<BrickCreator>();
        brickDestoyControl = GetComponent<BrickDestoyControl>();
        mapConvertor = GetComponent<ArrayMap>();
    }

}
