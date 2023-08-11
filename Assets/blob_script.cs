using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blob_script : MonoBehaviour
{

    public CircleCollider2D blobCollider;
    public Rigidbody2D rb;
    public float mobHP;
    private MainScript mainLogic;
    private ScoreManager scoreManager;
    // private Enemy_Spawner_Script spawnerScript;

    private void Start()
    {
        mainLogic = GameObject.FindGameObjectWithTag("Main").GetComponent<MainScript>();
        scoreManager = GameObject.FindGameObjectWithTag("HUD").GetComponent<ScoreManager>();
        // spawnerScript = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Enemy_Spawner_Script>();
    }

    void Update()
    {
        if (mobHP <= 0)
        {
            Destroy(this.gameObject);
            scoreManager.updatePlayerScore(1);
            // Debug.Log("playerScore" + scoreManager.playerScore);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile") {
            // Debug.Log(mainLogic.bulletDamage);
            mobHP -= mainLogic.bulletDamage;
        }
    }
}
