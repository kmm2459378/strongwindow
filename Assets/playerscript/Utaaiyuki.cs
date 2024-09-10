 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Burst.Intrinsics.X86;

public class Utaaiyuki : MonoBehaviour
{   //ゲームの時間
    
    //rigidbody2Dコンポーネントを使うための準備
    Rigidbody2D rigid2D;
    //ジャンプしたときにどれくらい飛ぶのか
    float jumpForce = 6000.0f;

    //animatorコンポーネントを使うために呼び出し
    Animator animator;

    // Start is called before the first frame update
    void Start()

    {
        //フレームを60で固定する
        Application.targetFrameRate = 60;

        //rigidbody2DをGetComponentで取得する 
        this.rigid2D = GetComponent<Rigidbody2D>();

        //animatorをGetComponentで取得する
        this.animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {   if (transform.position.x > 76  )
        {
            transform.Translate(-10, 0, 0);
        }      if(transform.position.x   < -76)
        {
            transform.Translate(10, 0, 0);
        }
        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject != null)
       
            return;
        //左に移動するボタンとそのスピード
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-10, 0, 0); //左に1
        }
        //右に移動するボタンとそのスピード
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(10, 0, 0);//右に1
        }
        //ジャンプするときのボタン
        //y方向のスピードが0の時しか飛べなくなる
        if (Input.GetMouseButtonDown(0) &&  this.rigid2D .velocity.y >= -0.5 && this.rigid2D.velocity.y <= 0.5)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            Debug.Log("aaa");
        }
        //GetComponent<AudioSource>().Play();
        
    }
    //ボタンで操作
    public void LButtonDown()
    {
        Debug.Log("aaa");
        transform.Translate(-10, 0,0);
    }

    public void RButtonDown()
    {
        Debug.Log("aaa");
        transform.Translate(10, 0, 0);
    }

    
    
}
 //(new Vector2)を入れるとtransform.upを書かなくてよいvector2が変わりに位置と方向を出してくれる便利なもの、vector3は3Dの時に使う