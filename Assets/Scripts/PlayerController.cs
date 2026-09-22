using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float flyForce = 15f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private float moveX;
    private bool isFlying;
    private bool hasStartedFlying = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        rb.gravityScale = 0f;
    }

    void Update()
    {
        moveX = 0f;

        if (Keyboard.current.aKey.isPressed)
            moveX = -1f;
       
        if (Keyboard.current.dKey.isPressed)
            moveX = 1f;

        isFlying = Keyboard.current.spaceKey.isPressed;

        if (isFlying)
        {
            hasStartedFlying = true;
        }

        if (moveX > 0)
            spriteRenderer.flipX = false;
        else if (moveX < 0)
            spriteRenderer.flipX = true;
    }

    void FixedUpdate()
    {
        if (hasStartedFlying)
        {
            rb.gravityScale = 1f;
        }

        rb.linearVelocity = new Vector2(
            moveX * moveSpeed,
            rb.linearVelocity.y
        );

        if (isFlying)
        {
            rb.AddForce(Vector2.up * flyForce, ForceMode2D.Force);
        }
    }
}