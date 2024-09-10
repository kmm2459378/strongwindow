using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
     public float countdown = 0;
     public float time = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ƒQ[ƒ€‚ÌŽžŠÔ
        this.countdown += Time.deltaTime;
        if (this.countdown >= this.time)
        {
            SceneManager.LoadScene("GameClear");
        }
    }
}
