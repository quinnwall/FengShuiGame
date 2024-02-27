using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringScript : MonoBehaviour
{
    
    public Text scoreText;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + "Points";
    }

    // Update is called once per frame
    public void AddPoints() {
        score += 1;
        scoreText.text = score.ToString() + "Points";
    }
}
