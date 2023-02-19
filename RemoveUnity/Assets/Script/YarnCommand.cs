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
    public GameObject script;

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

    //부엌식칼 확대 사진
    [YarnCommand("knifeZoomIn")]
    public static void KnifeZoomIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("KnifeZoom").gameObject.SetActive(true);
    }

    [YarnCommand("knifeZoomOut")]
    public static void KnifeZoomOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("KnifeZoom").gameObject.SetActive(false);
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

    //협박문자 확대 사진
    [YarnCommand("messageZoomIn")]
    public static void MessageZoomIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("MessageScreencaptureZoom").gameObject.SetActive(true);
    }

    [YarnCommand("messageZoomOut")]
    public static void MessageZoomOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("MessageScreencaptureZoom").gameObject.SetActive(false);
    }

    //진단서 사진
    [YarnCommand("medicalCertificateIn")]
    public static void medicalCertificateIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("MedicalCertificate").gameObject.SetActive(true);
    }

    [YarnCommand("medicalCertificateOut")]
    public static void medicalCertificateOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("MedicalCertificate").gameObject.SetActive(false);
    }

    //진단서 확대 사진
    [YarnCommand("medicalCertificateZoomIn")]
    public static void medicalCertificateZoomIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("MedicalCertificateZoom").gameObject.SetActive(true);
    }

    [YarnCommand("medicalCertificateZoomOut")]
    public static void medicalCertificateZoomOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("MedicalCertificateZoom").gameObject.SetActive(false);
    }

    //4번 사진
    [YarnCommand("picture4In")]
    public static void picture4In()
    {
        GameObject.Find("FadeCanvas").transform.Find("Picture4").gameObject.SetActive(true);
    }

    [YarnCommand("picture4Out")]
    public static void picture4Out()
    {
        GameObject.Find("FadeCanvas").transform.Find("Picture4").gameObject.SetActive(false);
    }

    //3, 4번 사진
    [YarnCommand("picture34In")]
    public static void picture34In()
    {
        GameObject.Find("FadeCanvas").transform.Find("Picture34Canvas").gameObject.SetActive(true);
    }

    [YarnCommand("picture34Out")]
    public static void picture34Out()
    {
        GameObject.Find("FadeCanvas").transform.Find("Picture34Canvas").gameObject.SetActive(false);
    }

    //34번 상세 사진
    [YarnCommand("picture34DetailIn")]
    public static void picture34DetailIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Picture34DetailCanvas").gameObject.SetActive(true);
    }

    [YarnCommand("picture34DetailOut")]
    public static void picture34DetailOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Picture34DetailCanvas").gameObject.SetActive(false);
    }



    //5번 사진
    [YarnCommand("picture5In")]
    public static void picture5In()
    {
        GameObject.Find("FadeCanvas").transform.Find("Picture5").gameObject.SetActive(true);
    }

    [YarnCommand("picture5Out")]
    public static void picture5Out()
    {
        GameObject.Find("FadeCanvas").transform.Find("Picture5").gameObject.SetActive(false);
    }

    //지연이 한강 대화사진
    [YarnCommand("hanriverIn")]
    public static void hanriverIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("HanriverTxt").gameObject.SetActive(true);
    }

    [YarnCommand("hanriverOut")]
    public static void hanriverOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("HanriverTxt").gameObject.SetActive(false);
    }

    //8-2번 사진
    [YarnCommand("picture8_2In")]
    public static void picture8_2In()
    {
        GameObject.Find("FadeCanvas").transform.Find("Picture8_2").gameObject.SetActive(true);
    }

    [YarnCommand("picture8_2Out")]
    public static void picture8_2Out()
    {
        GameObject.Find("FadeCanvas").transform.Find("Picture8_2").gameObject.SetActive(false);
    }

    //지연이 본가 대화 사진
    [YarnCommand("mainhouseIn")]
    public static void mainhouseIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Mainhouse").gameObject.SetActive(true);
    }

    [YarnCommand("mainhouseOut")]
    public static void mainhouseOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Mainhouse").gameObject.SetActive(false);
    }

    //띄어쓰기 사진
    [YarnCommand("WordspacingIn")]
    public static void WordspacingIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("WordSpacing").gameObject.SetActive(true);
    }

    [YarnCommand("WordspacingOut")]
    public static void WordspacingOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("WordSpacing").gameObject.SetActive(false);
    }

    //전공책 사진
    [YarnCommand("MajorbookIn")]
    public static void MajorbookIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Majorbook").gameObject.SetActive(true);
    }

    [YarnCommand("MajorbookOut")]
    public static void MajorbookOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Majorbook").gameObject.SetActive(false);
    }

    //사회 심리학 사진
    [YarnCommand("SocialpsyIn")]
    public static void SocialpsyIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Socialpsy").gameObject.SetActive(true);
    }

    [YarnCommand("SocialpsyOut")]
    public static void SocialpsyOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Socialpsy").gameObject.SetActive(false);
    }

    //재환 사회 심리학 사진
    [YarnCommand("SocialpsyTxtIn")]
    public static void SocialpsyTxtIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("SocialpsyTxt").gameObject.SetActive(true);
    }

    [YarnCommand("SocialpsyTxtOut")]
    public static void SocialpsyTxtOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("SocialpsyTxt").gameObject.SetActive(false);
    }

    //운동화 사진
    [YarnCommand("SneakerIn")]
    public static void SneakerIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Sneaker").gameObject.SetActive(true);
    }

    [YarnCommand("SneakerOut")]
    public static void SneakerOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Sneaker").gameObject.SetActive(false);
    }

    //구두 사진
    [YarnCommand("ShoesIn")]
    public static void ShoesIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Shoes").gameObject.SetActive(true);
    }

    [YarnCommand("ShoesOut")]
    public static void ShoesOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Shoes").gameObject.SetActive(false);
    }

    //반지 사진
    [YarnCommand("RingIn")]
    public static void ringIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("Ring").gameObject.SetActive(true);
    }

    [YarnCommand("RingOut")]
    public static void ringOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("Ring").gameObject.SetActive(false);
    }


    //또다른 반지 사진
    [YarnCommand("RingAnotherIn")]
    public static void RingAnotherIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("RingAnother").gameObject.SetActive(true);
    }

    [YarnCommand("RingAnotherOut")]
    public static void RingAnotherOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("RingAnother").gameObject.SetActive(false);
    }

    //오하나 대화내역 사진
    [YarnCommand("TxtWithHanaIn")]
    public static void TxtWithHanaIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("TxtWithHana").gameObject.SetActive(true);
    }

    [YarnCommand("TxtWithHanaOut")]
    public static void TxtWithHanaOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("TxtWithHana").gameObject.SetActive(false);
    }

    //캘린더 확대 사진
    [YarnCommand("CalenderDIn")]
    public static void CalenderDIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("CalenderD").gameObject.SetActive(true);
    }

    [YarnCommand("CalenderDOut")]
    public static void CalenderDOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("CalenderD").gameObject.SetActive(false);
    }

    //의문의 어플 사진
    [YarnCommand("ApplicationLIn")]
    public static void ApplicationLIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("ApplicationL").gameObject.SetActive(true);
    }

    [YarnCommand("ApplicationLOut")]
    public static void ApplicationLOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("ApplicationL").gameObject.SetActive(false);
    }

    //반지 두개 동시에
    [YarnCommand("TwoRingsIn")]
    public static void TwoRingsIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("RingCanvas").gameObject.SetActive(true);
    }

    [YarnCommand("TwoRingsOut")]
    public static void TwoRingsOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("RingCanvas").gameObject.SetActive(false);
    }


    //손가락 반지 사진
    [YarnCommand("FingerInRingIn")]
    public static void FingerInRingIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("FingerInRing").gameObject.SetActive(true);
    }

    [YarnCommand("FingerInRingOut")]
    public static void FingerInRingOut()
    {
        GameObject.Find("FadeCanvas").transform.Find("FingerInRing").gameObject.SetActive(false);
    }

    //8월 28일 메모 사진
    [YarnCommand("Memo_8_28In")]
    public static void Memo_8_28In()
    {
        GameObject.Find("FadeCanvas").transform.Find("Memo_8_28").gameObject.SetActive(true);
    }

    [YarnCommand("Memo_8_28Out")]
    public static void Memo_8_28Out()
    {
        GameObject.Find("FadeCanvas").transform.Find("Memo_8_28").gameObject.SetActive(false);
    }

    //재환 신신당부 사진
    [YarnCommand("TxtWithJaeIn")]
    public static void TxtWithJaeIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("TxtWithJae").gameObject.SetActive(true);
    }

    [YarnCommand("TxtWithJaeOut")]
    public static void TxtWithJae()
    {
        GameObject.Find("FadeCanvas").transform.Find("TxtWithJae").gameObject.SetActive(false);
    }

    //
    [YarnCommand("PasswordIn")]
    public static void PasswordIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("BirthdayImage").gameObject.SetActive(true);
    }

    [YarnCommand("DMeaningIn")]
    public static void DMeaningIn()
    {
        GameObject.Find("FadeCanvas").transform.Find("DMeaningImage").gameObject.SetActive(true);
    }
}


