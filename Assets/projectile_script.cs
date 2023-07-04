using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile_script : MonoBehaviour
{
    public cursor_script cursor;
    public player_script player;
    public Rigidbody2D rb;
    public CircleCollider2D collidorObject;
    private Vector2 headingDirection;
    public float projectileSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {

        cursor = GameObject.FindGameObjectWithTag("Cursor").GetComponent<cursor_script>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<player_script>();

        Vector2 playerLocation = player.transform.position;
        Vector2 cursorLocation = cursor.transform.position;

        headingDirection = cursorLocation.normalized;

        Debug.Log(headingDirection);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition((Vector2)transform.position + headingDirection * projectileSpeed * Time.fixedDeltaTime);
    }
}
