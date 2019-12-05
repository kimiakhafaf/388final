using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class switch_scene : MonoBehaviour
{
    public TextMeshProUGUI score, timer;
    private double time = 15.0;
    public static int point;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //add point if successfully slice the fruit
        time -= Time.deltaTime;
        int t = (int)time;
        timer.text = "Timer: " + t.ToString();
        score.text = "Points: " + point.ToString();
        if (time <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }

    public void start_game()
    {
        SceneManager.LoadScene("game");
    }
}
