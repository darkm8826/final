using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class healthBar : MonoBehaviour
{

    //��q�]�w

    public const int maxHealth = 100;

    public int currentHealth = maxHealth;

    //��q��

    public RectTransform HealthBar, Hurt;

    void Update()

    {

        //���UH�s����

        if (Input.GetKeyDown(KeyCode.H))

        {

            //�����ˮ`

            currentHealth = currentHealth - 10;

        }

        //�N������P�B���e��q����

        HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);

        //�e�{�ˮ`�q

        if (Hurt.sizeDelta.x > HealthBar.sizeDelta.x)

        {

            //���ˮ`�q(������)�v���l�W��e��q

            Hurt.sizeDelta += new Vector2(-1, 0) * Time.deltaTime * 10;

        }

    }

}