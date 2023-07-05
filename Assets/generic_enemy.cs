using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generic_enemy : MonoBehaviour
{

    public float movementSpeed = 2;
    private Vector2 playerLocation;
    public Rigidbody2D rb;
    private Vector2 directionToPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerLocation = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    private void FixedUpdate()
    {
        directionToPlayer = (playerLocation - (Vector2)transform.position).normalized;
        // rb.velocity = directionToPlayer * movementSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + directionToPlayer * movementSpeed * Time.fixedDeltaTime);
    }
}
