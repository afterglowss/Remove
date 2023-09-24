using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Yarn.Unity;

public class Stamina : MonoBehaviour
{

    int currentHour = TimeController.hour;
    int currentMinute = TimeController.min;
    float currentSec = TimeController.sec;


    private InMemoryVariableStorage variableStorage;
    private void Start()
    {
  
        variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
        int staminaNum = 0;
        int totalchance = 0;

        if (51> currentMinute && currentMinute >= 48)
        {
            GameObject.Find("Chance5").SetActive(false);
            GameObject.Find("Chance5_empty").SetActive(false);
            variableStorage.TryGetValue("$staminaNum", out staminaNum);
            variableStorage.SetValue("$staminaNum", staminaNum + 1);
            variableStorage.SetValue("$TotalChance", totalchance + 1);
        }

        else if (54> currentMinute && currentMinute >= 51)
        {
            GameObject.Find("Chance5").SetActive(false);
            GameObject.Find("Chance5_empty").SetActive(false);
            GameObject.Find("Chance4").SetActive(false);
            GameObject.Find("Chance4_empty").SetActive(false);
            variableStorage.TryGetValue("$staminaNum", out staminaNum);
            variableStorage.SetValue("$staminaNum", staminaNum + 1);
            variableStorage.SetValue("$TotalChance", totalchance + 2);
        }

        else if (currentMinute >= 54)
        {
            GameObject.Find("Chance5").SetActive(false);
            GameObject.Find("Chance5_empty").SetActive(false);
            GameObject.Find("Chance4").SetActive(false);
            GameObject.Find("Chance4_empty").SetActive(false);
            GameObject.Find("Chance3").SetActive(false);
            GameObject.Find("Chance3_empty").SetActive(false);
            variableStorage.TryGetValue("$staminaNum", out staminaNum);
            variableStorage.SetValue("$staminaNum", staminaNum + 1);
            variableStorage.SetValue("$TotalChance", totalchance + 3);

        }
    }



    [YarnCommand("stamina")]
    public static void StaminaControl()
    {
        if (GameObject.Find("Stamina").transform.Find("Chance5").gameObject.activeSelf == true)
        {
            GameObject.Find("Chance5").SetActive(false);
        }
        else if (GameObject.Find("Stamina").transform.Find("Chance4").gameObject.activeSelf == true)
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
