using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    private Vector2 ballInitialForce;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(10f, 0, 10f);
    }

    // Update is called once per frame
    void Update()
    {
            
    }
}
