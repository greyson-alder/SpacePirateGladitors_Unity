using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

    public GameObject cursor;
    public Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 playerLocation = player.transform.position;
        Vector2 cursorLocation = cursor.transform.position;

        Vector2 headingDirection = (playerLocation + cursorLocation);

        Debug.Log(headingDirection);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
