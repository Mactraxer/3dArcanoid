using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(10f, 0, 10f);
    }

}
