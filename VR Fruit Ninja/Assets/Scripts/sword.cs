using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class sword : MonoBehaviour
{
    public GameObject score;
    public GameObject final_score;
    //public TextMeshProUGUI score;

    public static int point = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTrackedRemote);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "fruit")
        {
            print("fruit");
            Destroy(collision.gameObject);
            point++;
            score.GetComponent<UnityEngine.UI.Text>().text = "Points: " + point.ToString();
            //final_score.GetComponent<UnityEngine.UI.Text>().text = "SCORE: " + point.ToString();
            //score.text = "Points: " + point.ToString();

        }
    }

}
