using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum Number
{
    one,
    two,
    three,
    four,
    five,
    six,
    seven,
    eight,
    nine,
    zero,
    Back,
    Enter
}
public class PasswordManager : MonoBehaviour
{
    public Number number;
    public static string password = "";

    public TextMeshProUGUI passwordText;
    public GameObject error;
    public GameObject PasswordScreen;
    public GameObject ShoutScreen;
    public static int opened = 0;  //��й�ȣ ��� �����Ǿ����� Ȯ���ϴ� �Լ�

    public void Start()
    {
        password = "";
        opened = 0;
    }
    public void NumberBtnClick()
    {
        switch (number)
        {
            case Number.one:
                password += "1";
                break;
            case Number.two:
                password += "2";
                break;
            case Number.three:
                password += "3";
                break;
            case Number.four:
                password += "4";
                break;
            case Number.five:
                password += "5";
                break;
            case Number.six:
                password += "6";
                break;
            case Number.seven:
                password += "7";
                break;
            case Number.eight:
                password += "8";
                break;
            case Number.nine:
                password += "9";
                break;
            case Number.zero:
                password += "0";
                break;
            case Number.Back:
                if (password.Length > 0)
                    password = password.Substring(0, password.Length - 1);
                break;
            case Number.Enter:
                if (password == "0828")
                {
                   // PhoneMove.i = 4;
                    opened = 1;
                    PasswordScreen.SetActive(false);
                    ShoutScreen.SetActive(true);
                    password = "";
                }
                else
                {
                    opened = 0;
                    password = "";
                    error.SetActive(true);
                    Invoke("ErrorDelete", 2f);
                }
                break;
        }
        Debug.Log(password);
        
    }

    private void ErrorDelete()
    {
        error.SetActive(false);
    }
    public void Update()
    {
        passwordText.text = password;
        if (password.Length > 4)
        {
            password = "";
        }
    }
}
