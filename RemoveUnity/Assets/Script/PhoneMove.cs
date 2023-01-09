using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PhoneMove : MonoBehaviour
{
    //public RectTransform rectTransform;
    private Transform cameraTransform;
    public GameObject Phone;
    Vector3 vel = Vector3.zero;
    //private Button button;

    void Awake()
    {
        cameraTransform = GameObject.Find("Main Camera").GetComponent<Transform>();
        Phone.transform.position = cameraTransform.position + new Vector3(0, -20, 100);
        //button = GetComponent<Button>();
    }

    public void PhoneUp()
    {
        StartCoroutine("Pull");
    }

    public void PhoneDown()
    {
        StartCoroutine("Push");
    }

    IEnumerator Pull()
    {
        while (true)
        {
            yield return null;
            Debug.Log("코루틴 돌아가는 중");
            //Phone.transform.position = Vector3.SmoothDamp(Phone.transform.position,
                //cameraTransform.position + new Vector3(0, 0, 100), ref vel, 0.5f);
            Phone.transform.position = Vector3.Lerp(Phone.transform.position,
                cameraTransform.position + new Vector3(0, 0, 100), Time.deltaTime * 3);
        }
    }
    IEnumerator Push()
    {
        while (true)
        {
            yield return null;
            Debug.Log("코루틴 돌아가는 중");
            //Phone.transform.position = Vector3.SmoothDamp(Phone.transform.position,
                //cameraTransform.position + new Vector3(0, -20, 100), ref vel, 0.5f);
            Phone.transform.position = Vector3.Lerp(Phone.transform.position,
                cameraTransform.position + new Vector3(0, -20, 100), Time.deltaTime * 3);
        }
    }
}
