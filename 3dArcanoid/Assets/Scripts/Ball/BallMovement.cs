using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private GameObject followByObject;
    private Rigidbody ballRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        ballRigidbody.isKinematic = true;
        //
    }

    private void Update()
    {
        ToFollow();
    }

    private void ToFollow()
    {
        if (ballRigidbody.isKinematic == false) { return; }
        gameObject.transform.position = new Vector3(followByObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    public void FireBall()
    {
        if (ballRigidbody.isKinematic)
        {
            ballRigidbody.velocity = new Vector3(10f, 0, 10f);
            ballRigidbody.isKinematic = false;
        }
        
    }

}
