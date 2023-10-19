using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{

    public Text _text;
    public Text _textOver;
    private int score;
    private string message;
    private int CandyCount;
    private bool GameOver = false;
    public Button Restart;

    // Start is called before the first frame update
    void Start()
    {
        Restart.GetComponent<Button>().enabled = false;
        Restart.GetComponentInChildren<Text>().enabled = false;
        Restart.GetComponent<Image>().enabled = false;
        _text.text = "Score:" + (score.ToString()) + message;
    }

    // Update is called once per frame
    void Update()
    {
        if (score <= 15)
            message = "Sadness";
        if (score >= 15 && score < 35)
            message = "Sugar Rush";
        if (score >= 35 && score <= 50)
            message = "Halloween";
        if (score > 50)
            message = "Candy Craze";
        if (score <= 15)
        _text.text = "Score:" + (score.ToString());
        if (GameOver) 
        {
            _textOver.text = "You got a Score of\n" + (score.ToString() + "\n" + message);
            Input.DisablePlayerControls();
            Restart.GetComponent<Button>().enabled = true;
            Restart.GetComponentInChildren<Text>().enabled = true;
            Restart.GetComponent<Image>().enabled = true;
        }
    }

    public void addScore(int add)
    {
        score += add;
    }

    public void CheckGame()
    {
        GameOver = true;
    }
    
    public void reset()
    {
        score = 0;
        message = "";
    }
}