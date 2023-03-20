using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hptest : MonoBehaviour
{
    public Image HealthBar;     //血?Image
    public Image HealthBar_BG;      //血??留?影Image
    public int Damage;          //?害
    public int MaxHealth = 100;       //最大生命
    public float FadeTime;      //????
    private bool startFade = false;
    [SerializeField]
    private float temp;

    private int currentHealth = 100;
    public int CurrentHealth            //?前血量
    {
        get
        {
            return currentHealth;
        }
        set
        {
            if (value < 0)
            {
                currentHealth = 0;
            }
            else
            {
                currentHealth = value;
            }
            HealthBar.fillAmount = (float)CurrentHealth / MaxHealth;
            temp = HealthBar_BG.fillAmount - HealthBar.fillAmount;
            startFade = true;       //????
        }
    }


    private void Start()
    {
        HealthBar.fillAmount = 1;
        HealthBar_BG.fillAmount = HealthBar.fillAmount;
    }

    private void Update()
    {
        FadeValue(HealthBar.fillAmount, FadeTime);
    }

    //血??影??
    public void FadeValue(float endValue, float duration)
    {
        if (startFade)
        {
            HealthBar_BG.fillAmount -= (temp / duration) * Time.deltaTime;    //temp/duration使用固定??的??。
            if (HealthBar_BG.fillAmount <= endValue)        //到??定值，????。
            {
                startFade = false;
            }
        }
    }

    //受到?害，??血?的?少
    public void TakeDamage()
    {
        CurrentHealth = CurrentHealth - Damage;
    }
}