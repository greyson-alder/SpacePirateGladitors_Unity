using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cursor_script: MonoBehaviour
{

    public GameObject projectile;
    public Rigidbody2D player;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;

        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Instantiate(projectile, new Vector3(player.transform.position.x, player.transform.position.y, 0), transform.rotation);
        }
    }
}
