using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (StageCreator))]
[RequireComponent(typeof (ArrayMap))]
public class StageController : MonoBehaviour, IBrickDelegate
{
    private StageCreator stageCreator;
    private ArrayMap mapConvertor;
    private BricksController brickController;

    [SerializeField]
    private Text brickCount;

    private int[,] stageMap;


    // Start is called before the first frame update
    void Start()
    {
        SetupController();
        GenerateMap();
        UpdateBrickCountLabel();
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
        brickController.GenerateBricks(stageMap, this);
    }

    private void StageComplete()
    {
        Debug.Log("Stage Clear");
    }

    public void SetupController()
    {
        brickController = GameObject.FindGameObjectWithTag("BricksManager").GetComponent<BricksController>();
        mapConvertor = GetComponent<ArrayMap>();
    }

    void IBrickDelegate.AllBricksDestroyed()
    {
        StageComplete();
    }

    void IBrickDelegate.BrickDestroyed()
    {
        UpdateBrickCountLabel();
    }

    private void UpdateBrickCountLabel()
    {
        brickCount.text = $"remained {brickController.BrickCount}";
    }
}
