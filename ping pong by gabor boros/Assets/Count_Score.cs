using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count_Score : MonoBehaviour {

    public Text Scoreboard;
    public GameObject ball;

    public static bool canAddScore = true;
    
    
    private int Bat_1_Score = 0;
    private int Bat_2_Score = 0;

	void Start ()
        {
            ball = GameObject.Find("Ball");
	    }
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (ball.transform.position.x >= 20f && canAddScore)
        {
            canAddScore = false;
            Bat_1_Score++;
        }
        if (ball.transform.position.x <= -20f && canAddScore)
        {
            canAddScore = false;
            Bat_2_Score++;
        }

        if(Bat_1_Score >= 7)
        {
            SceneManager.LoadScene(2);
        }
        if(Bat_2_Score >= 7)
        {
            SceneManager.LoadScene(3);
        }

        Scoreboard.text = Bat_1_Score.ToString() + " - " + Bat_2_Score.ToString();

	}
}
