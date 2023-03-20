using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // �ϥ� Text ���O�����ޤJ

public class LevelController : MonoBehaviour
{
    public Text countDownTxt; // ��r UI ���� (�즲���w)

    private float sceneTimeMax = 30; // �˼Ʈɶ� 30 ��
    private float sceneTimeStart = 0; // �O���i�J�����ɪ����

    void Start()
    {
        // �O���i�J�����ɪ����
        sceneTimeStart = Time.time;
    }

    void Update()
    {
        // �p��Ѿl���
        float timeLeft = sceneTimeMax - (Time.time - sceneTimeStart);

        // ��s�˼ƭp�� UI (�|�ˤ��J��p�ƲĤ@��)
        countDownTxt.text = (Mathf.Round(timeLeft * 1) / 1).ToString();
    }
}
