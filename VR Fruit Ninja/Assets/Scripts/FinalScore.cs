using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScore : MonoBehaviour
{

    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        //Reminder - Store the score in the previous scene using PlayerPrefs with the key 'score' - or tell Ben to do it cause he probably forgot to >:( 
        string results = "Score: " + PlayerPrefs.GetString("score"); 
        text.GetComponent<UnityEngine.UI.Text>().text = results;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
