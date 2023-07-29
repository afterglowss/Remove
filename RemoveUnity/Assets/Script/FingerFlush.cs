using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn;
using Yarn.Unity;

public class FingerFlush : MonoBehaviour
{

    static int fingerFlush = 0;

    [YarnFunction("getMyNumber")]
    public static int GetMyNumber()
    {
        return fingerFlush;
    }

    [YarnCommand("setMyNumber")]
    public static void SetMyNumber(int newNumber)
    {
        fingerFlush = newNumber;
    }
}

