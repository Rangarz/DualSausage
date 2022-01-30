using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoreText;
  //  public Text highscoreText;
    public float highScore;
    public float scoreAmount;
    public float pointIncreasesPerSecond;

    // Start is called before the first frame update
    void Start()
    { 
      scoreAmount = 0f;
      highScore=0f;
   //   highscoreText.text = PlayerPrefs.GetInt("highscoreText",0).ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score :" +(int)scoreAmount ;
        scoreAmount +=pointIncreasesPerSecond * Time.deltaTime;

       
        //if (scoreAmount > highScore)
        //{
        //    highScore = scoreAmount;
        //    scoreText.text = "HighScore :" + (int)highScore;
        //    PlayerPrefs.SetInt("highscoreText",(int)highScore);
        //}
    }


}
