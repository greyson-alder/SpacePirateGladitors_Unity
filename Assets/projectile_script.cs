using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class projectile_script : MonoBehaviour
{
    public cursor_script cursor;
    public player_script player;
    public Rigidbody2D rb;
    public CircleCollider2D collidorObject;
    public SpriteRenderer spriteRenderer;
    public MainScript mainLogic;
    public float projectileSpeed;
    public float projectileScale;

    private Vector2 _headingDirection;
    private Element _projectileElement;
    private Color _color;

    private float projectileLifetime = 1000;

    // Start is called before the first frame update
    void Start()
    {

        cursor = GameObject.FindGameObjectWithTag("Cursor").GetComponent<cursor_script>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<player_script>();
        mainLogic = GameObject.FindGameObjectWithTag("Main").GetComponent<MainScript>();

        projectileSpeed = mainLogic.bulletSpeed;
        projectileScale = mainLogic.bulletScale;

        Vector2 playerLocation = player.transform.position;
        Vector2 cursorLocation = cursor.transform.position;

        _headingDirection = (cursorLocation - playerLocation).normalized;
        _projectileElement = mainLogic.bulletElement;

        _color = _projectileElement.getElementColour();
        // Debug.Log(_projectileElement);
        spriteRenderer.color = _color;
        spriteRenderer.transform.localScale = Vector3.one * projectileScale;

    }

    // Update is called once per frame
    void Update()
    {
        if (projectileLifetime < 0) {
            Destroy(gameObject);

        }
        projectileLifetime -= 1;
    }

    private void FixedUpdate()
    {
        rb.MovePosition((Vector2)transform.position + _headingDirection * projectileSpeed * Time.fixedDeltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
