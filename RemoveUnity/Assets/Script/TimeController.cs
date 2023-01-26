using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;

public class TimeController : MonoBehaviour
{
    public Text gameTime;

    // ��ü ���� �ð��� �������ش�. ���⼭�� 180��.
    float setTime = 765;

    // �д����� �ʴ����� ����� ������ ������ش�.
    int hour;
    float sec;

    void Update()
    {
        // ���� �ð��� ���ҽ����ش�.
        setTime += Time.deltaTime;

        // ��ü �ð��� 60�� ���� Ŭ ��
        if (setTime >= 60f)
        {
            // 60���� ������ ����� ���� �д����� ����
            hour = (int)setTime / 60;
            // 60���� ������ ����� �������� �ʴ����� ����
            sec = setTime % 60;
            // UI�� ǥ�����ش�
            gameTime.text = hour + ":" + (int)sec;
        }

        // ��ü�ð��� 60�� �̸��� ��
        if (setTime < 60f)
        {
            // �� ������ �ʿ�������Ƿ� �ʴ����� ������ ����
            gameTime.text = (string)setTime;
        }

        // ���� �ð��� 0���� �۾��� ��
        if (setTime <= 0)
        {
            // UI �ؽ�Ʈ�� 0�ʷ� ������Ŵ.
            gameTime.text = "���� �ð� : 0��";
        }
    }

}

