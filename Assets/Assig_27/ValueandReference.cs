using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueandReference : MonoBehaviour
{
    int a = 10;
    int b = 20;

    void PlusToValue(int num1)
    {
        num1 += 10;
        Debug.Log("in the method of Value num1 = : " + num1);
    }
    void PlusToReference(ref int num2)
    {
        num2 += 10;
        Debug.Log("in the method of Reference num2 = : " + num2);

    }
    void OutMethod(out int num3)
    {
        num3 = 30;
    }
    void Start()
    {
        PlusToValue(a);
        Debug.Log("Call By Value = : " + a);
        PlusToReference(ref b);
        Debug.Log("Call By Reference = : " + b);
        int i;
        OutMethod(out i);
        Debug.Log(i);
    }
}
