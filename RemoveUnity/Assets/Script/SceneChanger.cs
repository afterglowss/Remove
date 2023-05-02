using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class SceneChanger : MonoBehaviour
{
    static Vector3 phonePosition;
    public GameObject Phone;
    public Transform cameraTransform;
    public void Awake()
    {
        phonePosition = new Vector3 (0,-11,100);
        PhonePositionUp();
    }

    private void Update()
    {
        Phone.transform.position = Vector3.Lerp(Phone.transform.position,
            cameraTransform.position + phonePosition, Time.deltaTime * 5);
    }
    [YarnCommand("phonePositionUp")]
    public static void PhonePositionUp()
    {
        phonePosition = new Vector3(0, 0, 100);
    }

    [YarnCommand("phonePositionDown")]
    public static void PhonePositionDown()
    {
        phonePosition = new Vector3(0, -11, 100);
    }
    //[YarnCommand("phoneUp")]
    //public void PhoneUp()
    //{
    //    Target = new Vector3(0, 0, 0);
    //}
    //[YarnCommand("phoneDown")]
    //public void PhoneDown()
    //{
    //    Target = new Vector3(0, -11, 0);
    //}
}
