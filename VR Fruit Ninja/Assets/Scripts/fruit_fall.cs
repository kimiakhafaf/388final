﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit_fall : MonoBehaviour
{
    public GameObject banana;
    public GameObject apple;
    public GameObject pear;
    public GameObject strawberry;
    public float spawnTime = .1f;            // How long between each spawn.
    private float timer = 0; //counting timer, reset after calling SpawnRandom() function
    public List<GameObject> fruitList;
    void Start(){
        fruitList.Add(banana);
        fruitList.Add(apple);
        fruitList.Add(pear);
        fruitList.Add(strawberry);
    }
    void Update()
    {
        timer += Time.deltaTime;   
        if (timer > spawnTime)
        {
            SpawnRandom();      
            timer = 0;     
        }
    }
    public void SpawnRandom()
    {

        for(int i = 0;i < Random.Range(2,5);i++){

            int spawn = Random.Range(0,fruitList.Count);
            Instantiate(fruitList[spawn],new Vector3(generateX(),generateY(),generateZ()),Quaternion.identity);
        }
        
    }

    //Play with these numbers, not sure what the right range is
    public float generateX(){
        return Random.Range(-3f,3f);
    }
    public float generateY(){
        return Random.Range(5f,10f);
    }
    public float generateZ(){
        return Random.Range(2f,3f);
    }
}
