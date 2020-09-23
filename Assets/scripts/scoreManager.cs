using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public int currentScore = 0;
    public Text text;
   
    private void Start()
    {
        //text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = currentScore.ToString();
    }
    public void addScore(int score)
    {
        currentScore += score;
        Debug.Log("score = " + currentScore);
    }

}
