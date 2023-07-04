using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{

    public float moveSpeed = 5;
    public Rigidbody2D rb;
    public Vector2 movement;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        // Player Input

        // -1 to 1, works with arrow keys and WASD by default
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    // executes on a fixed timer -- doesn't depend on FPS
    private void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
