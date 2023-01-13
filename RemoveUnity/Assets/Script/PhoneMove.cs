//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;


//public class PhoneMove : MonoBehaviour
//{
//    private Transform cameraTransform;
//    public GameObject Phone;
//    //Vector3 vel = Vector3.zero;

//    int i = 0;
//    static bool isCoroutineRunning = false;

//    void Awake()
//    {
//        cameraTransform = GameObject.Find("Main Camera").GetComponent<Transform>();
//        Phone.transform.position = cameraTransform.position + new Vector3(0, -11, 100);
//    }

//    public void PhoneUp()
//    {
//        if (isCoroutineRunning == false)
//        {
//            StartCoroutine("Pull");
//        }
//    }

//    public void PhoneDown()
//    {
//        if (isCoroutineRunning == false)
//        {
//            StartCoroutine("Push");
//        }
//    }

//    IEnumerator Pull()
//    {
//        i = 1;
//        isCoroutineRunning = true;
//        while (i<550)
//        {
//            yield return new WaitForEndOfFrame();
//            Debug.Log("코루틴 pull 돌아가는 중" + i); i++;
//            //Phone.transform.position = Vector3.SmoothDamp(Phone.transform.position,
//                //cameraTransform.position + new Vector3(0, 0, 100), ref vel, 0.5f);
//            Phone.transform.position = Vector3.Lerp(Phone.transform.position,
//                cameraTransform.position + new Vector3(0, 0, 100), Time.deltaTime * 3);
//        }
//        isCoroutineRunning = false;
//    }
//    IEnumerator Push()
//    {
//        i = 1;
//        isCoroutineRunning = true;
//        while (i<550)
//        {
//            yield return new WaitForEndOfFrame();
//            Debug.Log("코루틴 push 돌아가는 중" + i); i++;
//            //Phone.transform.position = Vector3.SmoothDamp(Phone.transform.position,
//                //cameraTransform.position + new Vector3(0, -20, 100), ref vel, 0.5f);
//            Phone.transform.position = Vector3.Lerp(Phone.transform.position,
//                cameraTransform.position + new Vector3(0, -11, 100), Time.deltaTime * 3);
//        }
//        isCoroutineRunning = false;
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PhoneMove : MonoBehaviour
{
    private Transform cameraTransform;
    public GameObject Phone;
    private Vector3 Target;


    void Awake()
    {
        cameraTransform = GameObject.Find("Main Camera").GetComponent<Transform>();
        Target = new Vector3(0, -11, 100);
    }

    public void PhoneUp()
    {
        Target = new Vector3(0, 0, 100);
    }

    public void PhoneDown()
    {
        Target = new Vector3(0, -11, 100);
    }

    private void Update()
    {
        Phone.transform.position = Vector3.Lerp(Phone.transform.position,
                cameraTransform.position + Target, Time.deltaTime * 5);
    }
}