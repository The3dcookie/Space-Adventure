using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text ScoreDisplay;

    private void Update()
    {
        ScoreDisplay.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Obstacle"))
        {
            score++;
            Debug.Log(" SCORE " +  score);
        }
    }
}
