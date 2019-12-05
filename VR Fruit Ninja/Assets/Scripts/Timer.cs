using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject countdown;
    float timeLeft = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        countdown.GetComponent<UnityEngine.UI.Text>().text = "Timer: 30";
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        countdown.GetComponent<UnityEngine.UI.Text>().text = "Timer: "+ Mathf.Round(timeLeft).ToString();
        if (timeLeft <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }
    public void start_game()
    {
        SceneManager.LoadScene("game");
    }

}

