using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenbollGenerator : MonoBehaviour
{
    public GameObject GreenbollPrefab;
    float span = 1.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(GreenbollPrefab);
            float px = Random.Range(-14.6f, 20.5f);
            go.transform.position = new Vector2(-91.6f, px);
        }
    }
}
