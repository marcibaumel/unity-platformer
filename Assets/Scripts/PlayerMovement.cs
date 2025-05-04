using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movementSpeed = 5.0f;
    public float horizontalMovement;
    void Start()
    {
        
    }

    void Update()
    {
        rb.linearVelocity = new Vector2(horizontalMovement * movementSpeed, rb.linearVelocityY);
    }

    public void Move(InputAction.CallbackContext context){
        horizontalMovement = context.ReadValue<Vector2>().x;
    }
}
