using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject dogPrehab;
    public GameObject GreenbollPrefab;
    public GameObject paperPrehab;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int image = Random.Range(0,3);
        this.delta += Time.deltaTime;
        if(image == 0)
        {
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject green = Instantiate(GreenbollPrefab);
            float px = Random.Range(-14.6f, 20.5f);
            green.transform.position = new Vector2(-108.0f, px);
        }
        }
        else if(image == 1)
        {
        if (this.delta > this.span)
        {
                this.delta = 0;
                GameObject dog  = Instantiate(dogPrehab);
                dog.transform.position = new Vector2(-108.0f, -30.0f);
        }
        }
        else if (image == 2)
        {
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject paper = Instantiate(this.paperPrehab);
            float px = Random.Range(-14.6f, 20.5f);
            paper.transform.position = new Vector2(-108.0f, px);
        }
        }
                                                            
    }
}
