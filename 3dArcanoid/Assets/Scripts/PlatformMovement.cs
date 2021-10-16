using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(moveDirection);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveDirection = new Vector2(context.ReadValue<float>(), 2);
    }

    private void Move(Vector2 direction)
    {
        float scaledMoveSpeed = moveSpeed * Time.deltaTime;

        Vector3 moveDirection = new Vector3(direction.x, 0, 0);
        transform.position += moveDirection * scaledMoveSpeed;
    }
}
