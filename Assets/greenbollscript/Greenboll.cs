using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UIElements;

public class Greenboll : MonoBehaviour
{   //GameObject��player��ݒ肷��
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {   //utaaiyuki��GameObject�ɐݒ肷��
        this.player = GameObject.Find("Utaaiyuki");
    }

    // Update is called once per frame
    void Update()
    {
        //greenboll�𓙑��ŉ������Ŕ�΂�
        transform.Translate(1.0f, 0, 0);

        //��ʊO�ɏo�������
        if(transform.position.x > 109.2f) 
        {
            Destroy(gameObject);�@�@//�폜����
        }

        //�����蔻��
        Vector2 g1 = transform.position;   //��̒��S���W
        Vector2 g2 = this.player.transform.position;�@�@//utaaiyuki�̒��S���W
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
