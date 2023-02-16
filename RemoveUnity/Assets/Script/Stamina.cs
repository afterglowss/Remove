using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Stamina : MonoBehaviour
{
    [YarnCommand("stamina")]
    public static void StaminaControl()
    {
        if (GameObject.Find("Stamina").transform.Find("Chance4").gameObject.activeSelf == true)
        {
            GameObject.Find("Chance4").SetActive(false);
        }
        else if (GameObject.Find("Stamina").transform.Find("Chance3").gameObject.activeSelf == true)
        {
            GameObject.Find("Chance3").SetActive(false);
        }
        else if (GameObject.Find("Stamina").transform.Find("Chance2").gameObject.activeSelf == true)
        {
            GameObject.Find("Chance2").SetActive(false);
        }
        else
            GameObject.Find("Chance1").SetActive(false);
    }

}
