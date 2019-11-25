using System.Collections;
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
        Instantiate(banana, new Vector3(Random.Range(-2, 2), Random.Range(5, 10) , Random.Range(4, 6)), Quaternion.identity);
        Instantiate(apple, new Vector3(Random.Range(-2, 2), Random.Range(5, 10), Random.Range(4, 6)), Quaternion.identity);
        Instantiate(pear, new Vector3(Random.Range(-2, 2), Random.Range(5, 10), Random.Range(4, 6)), Quaternion.identity);
        Instantiate(strawberry, new Vector3(Random.Range(-2, 2), Random.Range(5, 10), Random.Range(4, 6)), Quaternion.identity);
        Instantiate(banana, new Vector3(Random.Range(-2, 2), Random.Range(10, 15), Random.Range(4, 6)), Quaternion.identity);
        Instantiate(apple, new Vector3(Random.Range(-2, 2), Random.Range(10, 15), Random.Range(4, 6)), Quaternion.identity);
        Instantiate(pear, new Vector3(Random.Range(-2, 2), Random.Range(5, 10), Random.Range(4, 6)), Quaternion.identity);
        Instantiate(strawberry, new Vector3(Random.Range(-2, 2), Random.Range(5, 10), Random.Range(4, 6)), Quaternion.identity);
        
    }
}
