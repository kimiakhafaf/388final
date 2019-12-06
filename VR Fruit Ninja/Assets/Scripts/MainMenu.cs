using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    //Fall speed increases as difficulty increases

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public int easy(){
        return 15;
    }

    public int medium(){
        return 12;
    }

    public int hard(){
        return 10;
    }
}
