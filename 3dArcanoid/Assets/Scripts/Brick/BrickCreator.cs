using UnityEngine;
using UnityEngine.Events;

public class BrickCreator : MonoBehaviour
{

    [SerializeField] GameObject brickPrefab;
    private float zOffset = 3f;
    
    public Brick[,] CreateBricksByMap(int[,] brickMap, Brick.DethAction destroyEvent, UnityAction<Brick> collisitionAction)
    {
        int dimentionXSize = brickMap.GetUpperBound(0);
        int dimentionYSize = brickMap.GetUpperBound(1);
        // TODO think about List instead Array
        Brick[,] bricks = new Brick[dimentionXSize + 1, dimentionYSize + 1];
        for (int i = 0; i <= dimentionXSize; i++)
        {
            for (int j = 0; j <= dimentionYSize; j++)
            {
                if (brickMap[i, j] == 0) { continue; }
                GameObject brickGameObject = Instantiate(brickPrefab, new Vector3(-dimentionXSize / 2 + j, 0.5f, dimentionYSize - i + zOffset), Quaternion.identity);
                brickGameObject.GetComponent<BrickCollition>().CollisionAction.AddListener(collisitionAction);

                Brick brick = new Brick(3, brickGameObject, destroyEvent);
                brickGameObject.GetComponent<BrickCollition>().SetBrick(brick);
                bricks[i, j] = brick;
                
            }
        }

        return bricks;
    }

}
