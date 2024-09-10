using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Dog : MonoBehaviour
{
    GameObject Dog01;
    GameObject player;
    Rigidbody2D rigid2D;
    float jumpforce = 6000.0f;
    bool hasJumped = false;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.player = GameObject.Find("Utaaiyuki");
    }
   
    // Update is called once per frame
    void Update()
    {   
        transform.Translate(-2.0f, 0, 0);
        float px = Random.Range(-30.0f,73.0f);
        //Dog01.transform.position = new Vector2(-86.2f, px);
        if (hasJumped == false && px > -30.0f && px < 73.0f)
        {
            this.rigid2D.AddForce(transform.up*this.jumpforce);
            hasJumped = true;
        }

        if (transform.position.x > 109.2f)
        {
            Destroy(gameObject);
        }

        Vector2 d1 = transform.position;
        Vector2 d2 = this.player.transform.position;
        Vector2 dog = d1 - d2;
        float d = dog.magnitude;
        float t1 = 8.0f;
        float t2 = 8.0f;

        if (d < t1 + t2)
        {
            GameObject director = GameObject.Find("HpGauge");
            director.GetComponent<HpGauge>().DecreaseHp(20);
            Destroy(gameObject);
        }
       

    }
}
