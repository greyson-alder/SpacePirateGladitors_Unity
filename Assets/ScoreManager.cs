using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreElement;

    public int playerScore = 0;

    public void updatePlayerScore(int scoreValue)
    {
        playerScore += scoreValue;
        scoreElement.text = playerScore.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
