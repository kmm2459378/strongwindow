using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newspaper : MonoBehaviour
{
    // Start is called before the first frame update
    //gameobjectにplayerを設定する
    GameObject player;
    void Start()
    {   
        this.player = GameObject.Find("Utaaiyuki");
    }

    // Update is called once per frame
    void Update()
    {   //新聞紙を1のスピードで横向きに飛ばす
        transform.Translate(1f, 0, 0);

        //画面外に消えたらオブジェクトの破壊
        if (transform.position.x > 109.2f)
        {
            Destroy(gameObject);
        }

        //当たり判定
        Vector2 p1 = transform.position;   //矢の中心座標
        Vector2 p2 = this.player.transform.position; //playerの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;  //平方根の計算をしてくれて、float型に直してくれる変数結構おもい計算
        float r1 = 5.0f;
        float r2 = 5.0f;
         //二つの半径の合計よりも二つの物体の距離の方が短いから当たり判定になる
        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("HpGauge");
            director.GetComponent<HpGauge>().DecreaseHp(5);
            Destroy(gameObject);
        }
    }
}
