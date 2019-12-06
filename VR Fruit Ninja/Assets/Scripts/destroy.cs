using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    
    private float timer = 0;        

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,7);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (transform.position.y <= 0)
        {
            Destroy(this.gameObject);
        }

    }

    void onCollisionEnter(Collider other){
        if(other.gameObject.tag == "floor"){
            Destroy(this.gameObject);
        }
    }
}
