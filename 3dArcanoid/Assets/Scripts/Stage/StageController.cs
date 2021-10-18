using UnityEngine;

public class StageController : MonoBehaviour
{
    private StageCreator stageCreator;

    private int[,] stageMap;


    // Start is called before the first frame update
    void Start()
    {
        stageMap = new int[10, 10];
        stageCreator = GetComponent<StageCreator>();
        stageCreator.CreateStageByMap(stageMap);
    }

}
