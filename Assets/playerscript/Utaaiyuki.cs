 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.Burst.Intrinsics.X86;

public class Utaaiyuki : MonoBehaviour
{   //�Q�[���̎���
    
    //rigidbody2D�R���|�[�l���g���g�����߂̏���
    Rigidbody2D rigid2D;
    //�W�����v�����Ƃ��ɂǂꂭ�炢��Ԃ̂�
    float jumpForce = 6000.0f;

    //animator�R���|�[�l���g���g�����߂ɌĂяo��
    Animator animator;

    // Start is called before the first frame update
    void Start()

    {
        //�t���[����60�ŌŒ肷��
        Application.targetFrameRate = 60;

        //rigidbody2D��GetComponent�Ŏ擾���� 
        this.rigid2D = GetComponent<Rigidbody2D>();

        //animator��GetComponent�Ŏ擾����
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
        //���Ɉړ�����{�^���Ƃ��̃X�s�[�h
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-10, 0, 0); //����1
        }
        //�E�Ɉړ�����{�^���Ƃ��̃X�s�[�h
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(10, 0, 0);//�E��1
        }
        //�W�����v����Ƃ��̃{�^��
        //y�����̃X�s�[�h��0�̎�������ׂȂ��Ȃ�
        if (Input.GetMouseButtonDown(0) &&  this.rigid2D .velocity.y >= -0.5 && this.rigid2D.velocity.y <= 0.5)
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            Debug.Log("aaa");
        }
        //GetComponent<AudioSource>().Play();
        
    }
    //�{�^���ő���
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
 //(new Vector2)�������transform.up�������Ȃ��Ă悢vector2���ς��Ɉʒu�ƕ������o���Ă����֗��Ȃ��́Avector3��3D�̎��Ɏg��