using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newspaper : MonoBehaviour
{
    // Start is called before the first frame update
    //gameobject��player��ݒ肷��
    GameObject player;
    void Start()
    {   
        this.player = GameObject.Find("Utaaiyuki");
    }

    // Update is called once per frame
    void Update()
    {   //�V������1�̃X�s�[�h�ŉ������ɔ�΂�
        transform.Translate(1f, 0, 0);

        //��ʊO�ɏ�������I�u�W�F�N�g�̔j��
        if (transform.position.x > 109.2f)
        {
            Destroy(gameObject);
        }

        //�����蔻��
        Vector2 p1 = transform.position;   //��̒��S���W
        Vector2 p2 = this.player.transform.position; //player�̒��S���W
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;  //�������̌v�Z�����Ă���āAfloat�^�ɒ����Ă����ϐ����\�������v�Z
        float r1 = 5.0f;
        float r2 = 5.0f;
         //��̔��a�̍��v������̕��̂̋����̕����Z�����瓖���蔻��ɂȂ�
        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("HpGauge");
            director.GetComponent<HpGauge>().DecreaseHp(5);
            Destroy(gameObject);
        }
    }
}
