using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector2 moveInput;
    public void onclick()
    {
        Debug.Log("Button Clicked!");
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    public void OnMove(InputAction.CallbackContext context)
    
        moveInput = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        rb.velocity = new Vector3(move.x * moveSpeed, rb.velocity.y, move.z * moveSpeed);
    }
}