using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class SceneChanger : MonoBehaviour
{
    static Vector3 phonePosition;
    public GameObject Phone;
    public void Awake()
    {
        phonePosition = new Vector3(0,0,0);
    }

    private void Update()
    {
        Phone.transform.position = Vector3.Lerp(Phone.transform.position, 
            phonePosition, Time.deltaTime * 2.5f);
    }

    [YarnCommand("phonePositionDown")]
    public static void PhonePositionDown()
    {
        phonePosition = new Vector3(0, -11, 0);
    }
}
