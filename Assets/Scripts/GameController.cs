using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Star star;
    public Text score;
    public Text timer;
    public Button resetButton;
    public Text gameOver;
    public Text highScore;

    private int current_score;
    private int high_score;
    private int game_time;
    private int end_time;

    public StarSpawner destroyerOfWorlds;

    private bool timerStatus = true;

    public int countdown = 5;

    // Start is called before the first frame update
    void Start()
    {
        game_time = (int)Time.time;
    
        end_time = (int)Time.time + countdown;
        gameOver.gameObject.SetActive(false);
        resetButton.gameObject.SetActive(false);

        //star.gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(Time.time); 
        if (timerStatus)
        {
            game_time = (int)Time.time;
            game_time = end_time - game_time;
        }
   

        if(game_time < 1 )
        {

            game_time = 0;
            timerStatus = false;
            UpdateHighScore();
            gameOver.gameObject.SetActive(true);
            resetButton.gameObject.SetActive(true);
            //star.gameObject.SetActive(false);
            destroyerOfWorlds.DestroyAllStars();
        }

        score.text = "Score: " + current_score;
        timer.text = "Time: " + game_time.ToString();
        gameOver.text = "Final Score: " + current_score;

    }

    public void IncreaseScore()
    {
        if(timerStatus)
        {
            current_score += 1;
        }
        
    }

    public void ResetGame()
    {
        current_score = 0;
        game_time = (int)Time.time;
        end_time = (int)Time.time + countdown;
        gameOver.gameObject.SetActive(false);
        resetButton.gameObject.SetActive(false);
//        star.gameObject.SetActive(true);
  //      star.ResetPositionAndScale();
        timerStatus = true;
        destroyerOfWorlds.DestroyAllStars();
        destroyerOfWorlds.SpawnStar();
    }

    public Vector3 getNewPos()
    {
        float x, y;

        x = Random.Range(-8.0f, 8.0f);
        y = Random.Range(-4.0f, 4.0f);
       

        return new Vector3(x, y);
    }



    public void UpdateHighScore()
    {
        if(current_score > high_score)
        {
            high_score = current_score;
            highScore.text = "High Score: " + current_score;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
    }


}
