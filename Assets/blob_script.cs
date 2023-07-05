using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blob_script : MonoBehaviour
{

    public CircleCollider2D blobCollider;
    public Rigidbody2D rb;
    public float mobHP = 30f;
    private MainScript mainLogic;

    private void Start()
    {
        mainLogic = GameObject.FindGameObjectWithTag("Main").GetComponent<MainScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mobHP <= 0)
        {
            // this needs to target only the instantiated object
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile") {
            Debug.Log(mainLogic.bulletDamage);
            mobHP -= mainLogic.bulletDamage;
        }
    }
}
