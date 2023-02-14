using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class EventManager : MonoBehaviour
{
    GameObject mentalHospital;
    public void Awake()
    {
        mentalHospital = GameObject.Find("MentalHospital");
    }
}
