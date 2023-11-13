using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class rezSkripta : MonoBehaviour
{
    int score;
    public TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("PROBAAAAAAAAAAAA");
        score = PlayerPrefs.GetInt("score", 0);
        score = 100 - score;
        string scoreString = score.ToString(); 
        ScoreText.text = scoreString;
        //Debug.Log("scoreeeeeeeeee");
        //Debug.Log(scoreString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
