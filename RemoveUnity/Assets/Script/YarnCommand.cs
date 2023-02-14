using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Yarn.Unity;

public class YarnCommand : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    /*--------이 부분은 추리씬에서의 사진을 다루는 스크립트입니다------*/

    //파란박스 조작부분

    //파란박스 1번
    [YarnCommand("bluebox1_In")]
    public static void AccidentIn()
    {
        GameObject.Find("TextCanvas").transform.Find("Accident1").gameObject.SetActive(true);
        GameObject.Find("TextCanvas").transform.Find("Accident2").gameObject.SetActive(true);
    }

    [YarnCommand("bluebox1_Out")]
    public static void AccidentOut()
    {
        GameObject.Find("TextCanvas").transform.Find("Accident1").gameObject.SetActive(false);
        GameObject.Find("TextCanvas").transform.Find("Accident2").gameObject.SetActive(false);
    }

    //파란박스 2번
    [YarnCommand("bluebox2_In")]
    public static void WeaponIn()
    {
        GameObject.Find("TextCanvas").transform.Find("Weapon1").gameObject.SetActive(true);
        GameObject.Find("TextCanvas").transform.Find("Weapon2").gameObject.SetActive(true);
    }
    [YarnCommand("bluebox2_Out")]
    public static void WeaponOut()
    {
        GameObject.Find("TextCanvas").transform.Find("Weapon1").gameObject.SetActive(false);
        GameObject.Find("TextCanvas").transform.Find("Weapon2").gameObject.SetActive(false);
    }

    //파란박스 3번
    [YarnCommand("bluebox3_In")]
    public static void FakingIn()
    {
        GameObject.Find("TextCanvas").transform.Find("Faking1").gameObject.SetActive(true);
        GameObject.Find("TextCanvas").transform.Find("Faking2").gameObject.SetActive(true);
    }
    [YarnCommand("bluebox3_Out")]
    public static void FakingOut()
    {
        GameObject.Find("TextCanvas").transform.Find("Faking1").gameObject.SetActive(false);
        GameObject.Find("TextCanvas").transform.Find("Faking2").gameObject.SetActive(false);
    }

    //파란박스 4번
    [YarnCommand("bluebox4_In")]
    public static void RelationshipIn()
    {
        GameObject.Find("TextCanvas").transform.Find("Relationship1").gameObject.SetActive(true);
        GameObject.Find("TextCanvas").transform.Find("Relationship2").gameObject.SetActive(true);
    }
    [YarnCommand("bluebox4_Out")]
    public static void RelationshipOut()
    {
        GameObject.Find("TextCanvas").transform.Find("Relationship1").gameObject.SetActive(false);
        GameObject.Find("TextCanvas").transform.Find("Relationship2").gameObject.SetActive(false);
    }

    //파란박스 5번
    [YarnCommand("bluebox5_In")]
    public static void RingIn()
    {
        GameObject.Find("TextCanvas").transform.Find("Ring1").gameObject.SetActive(true);
        GameObject.Find("TextCanvas").transform.Find("Ring2").gameObject.SetActive(true);
    }
    [YarnCommand("bluebox5_Out")]
    public static void RingOut()
    {
        GameObject.Find("TextCanvas").transform.Find("Ring1").gameObject.SetActive(false);
        GameObject.Find("TextCanvas").transform.Find("Ring2").gameObject.SetActive(false);
    }

    //파란박스 6번
    [YarnCommand("bluebox6_In")]
    public static void ApplicationIn()
    {
        GameObject.Find("TextCanvas").transform.Find("Application1").gameObject.SetActive(true);
        GameObject.Find("TextCanvas").transform.Find("Application2").gameObject.SetActive(true);
    }
    [YarnCommand("bluebox6_Out")]
    public static void ApplicationOut()
    {
        GameObject.Find("TextCanvas").transform.Find("Application1").gameObject.SetActive(false);
        GameObject.Find("TextCanvas").transform.Find("Application2").gameObject.SetActive(false);
    }


    //사진 조작 부분

    //망치사진
    [YarnCommand("hammerIn")]
    public static void HammerIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Hammer").gameObject.SetActive(true);
    }

    [YarnCommand("hammerOut")]
    public static void HammerOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Hammer").gameObject.SetActive(false);
    }

    //손가락 사진
    [YarnCommand("fingerIn")]
    public static void FingerIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Finger").gameObject.SetActive(true);
    }

    [YarnCommand("fingerOut")]
    public static void FingerOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Finger").gameObject.SetActive(false);
    }

    //부엌식칼 사진
    [YarnCommand("knifeIn")]
    public static void KnifeIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Knife").gameObject.SetActive(true);
    }

    [YarnCommand("knifeOut")]
    public static void KnifeOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Knife").gameObject.SetActive(false);
    }

    //창문 위 손자국 사진
    [YarnCommand("handprintIn")]
    public static void HandprintIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Handprint").gameObject.SetActive(true);
    }

    [YarnCommand("handprintOut")]
    public static void HandprintOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Handprint").gameObject.SetActive(false);
    }

    //손자국 대화창 사진
    [YarnCommand("handprintTxtIn")]
    public static void HandprintTxtIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("HandprintText").gameObject.SetActive(true);
    }

    [YarnCommand("handprintTxtOut")]
    public static void HandprintTxtOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("HandprintText").gameObject.SetActive(false);
    }


    //협박문자 사진
    [YarnCommand("messageIn")]
    public static void MessageIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("MessageScreencapture").gameObject.SetActive(true);
    }

    [YarnCommand("messageOut")]
    public static void MessageOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("MessageScreencapture").gameObject.SetActive(false);
    }
}


