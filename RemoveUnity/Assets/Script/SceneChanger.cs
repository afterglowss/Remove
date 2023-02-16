using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    Vector3 Target;
    public GameObject Phone;
    public void Awake()
    {
        Target = new Vector3(0,0,0);
        Invoke("PhoneDown", 81.5f);
    }

    private void Update()
    {
        Phone.transform.position = Vector3.Lerp(Phone.transform.position, 
            Target, Time.deltaTime * 5);
    }
    public void PhoneDown()
    {
        Target = new Vector3(0, -11, 0);
    }
}
