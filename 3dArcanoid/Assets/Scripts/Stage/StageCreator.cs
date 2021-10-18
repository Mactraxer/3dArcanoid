using UnityEngine;

public class StageCreator : MonoBehaviour
{
    [SerializeField] GameObject wallPrefab;
    [SerializeField] GameObject platePrefab;
    private float offset = 4f;

    public void CreateStageByMap(int[,] stageMap)
    {
        float dimentionXSize = stageMap.GetUpperBound(0) + offset;
        float dimentionYSize = stageMap.GetUpperBound(1) + offset;

        GameObject leftWall = Instantiate(wallPrefab, new Vector3(-dimentionXSize / 2 - 0.5f, 1, dimentionYSize / 2), Quaternion.identity);
        leftWall.transform.localScale = new Vector3(1, 2, dimentionYSize);
        leftWall.name = "leftWall";

        GameObject rightWall = Instantiate(wallPrefab, new Vector3(dimentionXSize / 2 + 0.5f, 1, dimentionYSize / 2), Quaternion.identity);
        rightWall.transform.localScale = new Vector3(1, 2, dimentionYSize);
        rightWall.name = "leftWall";

        GameObject backWall = Instantiate(wallPrefab, new Vector3(0, 1, dimentionYSize + 0.5f), Quaternion.identity);
        backWall.transform.localScale = new Vector3(dimentionXSize, 2, 1);
        backWall.name = "backWall";


        GameObject plate = Instantiate(platePrefab, new Vector3(0, 0, dimentionYSize / 2), Quaternion.identity);
        plate.transform.localScale = new Vector3(dimentionXSize / 10f, 1, dimentionYSize / 10f);


    }


}
