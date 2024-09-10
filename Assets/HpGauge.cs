using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpGauge : MonoBehaviour
{
    GameObject hpGauge;
    public int hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHp(int damage)
    {   if(damage == 5)
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.05f;
        if (damage == 10)
            this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f; 
        if (damage == 20)
            this.hpGauge.GetComponent<Image>().fillAmount -= 0.2f;
        this.hp -= damage;
        if(this.hp < 1)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
