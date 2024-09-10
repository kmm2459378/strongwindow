using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UIElements;

public class Greenboll : MonoBehaviour
{   //GameObjectにplayerを設定する
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {   //utaaiyukiをGameObjectに設定する
        this.player = GameObject.Find("Utaaiyuki");
    }

    // Update is called once per frame
    void Update()
    {
        //greenbollを等速で横方向で飛ばす
        transform.Translate(1.0f, 0, 0);

        //画面外に出たら消す
        if(transform.position.x > 109.2f) 
        {
            Destroy(gameObject);　　//削除する
        }

        //当たり判定
        Vector2 g1 = transform.position;   //矢の中心座標
        Vector2 g2 = this.player.transform.position;　　//utaaiyukiの中心座標
        Vector2 dir2 = g1 - g2;       
        float d2 = dir2.magnitude;      
        float x1 = 6.0f;        
        float x2 = 6.0f;
        
        if( d2 < x1 + x2)
        {
            GameObject director = GameObject.Find("HpGauge");
            director.GetComponent<HpGauge>().DecreaseHp(10);
         Destroy(gameObject);
        }

    }
}
