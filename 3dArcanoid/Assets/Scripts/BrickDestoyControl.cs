using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDestoyControl : MonoBehaviour
{
    public GameObject[] gameObjectBricks;
    private List<Brick> bricks;

    // Start is called before the first frame update
    void Start()
    {
        bricks = new List<Brick>();
        foreach (GameObject gameObjectBrick in gameObjectBricks)
        {
            bricks.Add(new Brick(3, DestroyBrick));
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BrickCollision()
    {
        bricks[0].ApplyDamage(1);
    }

    private void DestroyBrick()
    {
        Destroy(gameObjectBricks[0]);
    }
}
