using UnityEngine;
using UnityEngine.Events;

public class BrickCreator : MonoBehaviour
{

    [SerializeField] GameObject brickPrefab;
    
    public Brick[,] CreateBricksByMap(int[,] brickMap, Brick.DethAction destroyEvent, UnityAction<Brick> collisitionAction)
    {
        Brick[,] bricks = new Brick[brickMap.GetUpperBound(0) + 1, brickMap.GetUpperBound(1) + 1];
        for (int i = 0; i <= brickMap.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= brickMap.GetUpperBound(1); j++)
            {
                GameObject brickGameObject = Instantiate(brickPrefab, new Vector3(j, 0.5f, i), Quaternion.identity);
                brickGameObject.GetComponent<BrickCollition>().CollisionAction.AddListener(collisitionAction);

                Brick brick = new Brick(3, brickGameObject, destroyEvent);
                brickGameObject.GetComponent<BrickCollition>().SetBrick(brick);
                bricks[i, j] = brick;
                
            }
        }

        return bricks;
    }

}
