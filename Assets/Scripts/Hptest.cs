using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hptest : MonoBehaviour
{
    public Image HealthBar;     //��?Image
    public Image HealthBar_BG;      //��??�d?�vImage
    public int Damage;          //?�`
    public int MaxHealth = 100;       //�̤j�ͩR
    public float FadeTime;      //????
    private bool startFade = false;
    [SerializeField]
    private float temp;

    private int currentHealth = 100;
    public int CurrentHealth            //?�e��q
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

    //��??�v??
    public void FadeValue(float endValue, float duration)
    {
        if (startFade)
        {
            HealthBar_BG.fillAmount -= (temp / duration) * Time.deltaTime;    //temp/duration�ϥΩT�w??��??�C
            if (HealthBar_BG.fillAmount <= endValue)        //��??�w�ȡA????�C
            {
                startFade = false;
            }
        }
    }

    //����?�`�A??��?��?��
    public void TakeDamage()
    {
        CurrentHealth = CurrentHealth - Damage;
    }
}