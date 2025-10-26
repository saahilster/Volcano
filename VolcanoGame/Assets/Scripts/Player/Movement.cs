using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    InputSystem_Actions playerControls;
    InputAction move;
    float moveSpeed = 4;
    Rigidbody2D rb;
    Vector2 movement = Vector2.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerControls = new InputSystem_Actions();
        rb = GetComponent<Rigidbody2D>();

    }

    void OnEnable()
    {
        move = playerControls.Player.Move;
        move.Enable();
    }
    void OnDisable()
    {
        move.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        movement = move.ReadValue<Vector2>();
    }
    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }
}
