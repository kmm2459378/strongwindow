using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodPrehab : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dogPrehab;
    float span = 2.0f;
    float delta = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
         GameObject dogs = Instantiate(dogPrehab);
        dogs.transform.position = new Vector2(-106, -22);
        }
        
        
    }
}
