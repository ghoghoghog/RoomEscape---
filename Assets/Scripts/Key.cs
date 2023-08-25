using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public Outline selection1;
    public static int first = 1;
    public Outline selection2;
    public static int second = 1;
    public Outline selection3;
    public static int third = 1;
    public Outline selection4;
    public static int fourth = 1;
    public Outline selection5;
    public static int fifth = 1;

    public bool isOutlineEnabled1 = false;
    public bool isOutlineEnabled2 = false;
    public bool isOutlineEnabled3 = false;
    public bool isOutlineEnabled4 = false;
    public bool isOutlineEnabled5 = false;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            first = 0;
            second = 1;
            third = 1;
            fourth = 1;
            fifth = 1;
            isOutlineEnabled1 = !isOutlineEnabled1;
            isOutlineEnabled2 = false;
            isOutlineEnabled3 = false;
            isOutlineEnabled4 = false;
            isOutlineEnabled5 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            first = 1;
            second = 0;
            third = 1;
            fourth = 1;
            fifth = 1;
            isOutlineEnabled2 = !isOutlineEnabled2;
            isOutlineEnabled1 = false;
            isOutlineEnabled3 = false;
            isOutlineEnabled4 = false;
            isOutlineEnabled5 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            first = 1;
            second = 1;
            third = 0;
            fourth = 1;
            fifth = 1;
            isOutlineEnabled3 = !isOutlineEnabled3;
            isOutlineEnabled2 = false;
            isOutlineEnabled1 = false;
            isOutlineEnabled4 = false;
            isOutlineEnabled5 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            first = 1;
            second = 1;
            third = 1;
            fourth = 0;
            fifth = 1;
            isOutlineEnabled4 = !isOutlineEnabled4;
            isOutlineEnabled2 = false;
            isOutlineEnabled3 = false;
            isOutlineEnabled1 = false;
            isOutlineEnabled5 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            first = 1;
            second = 1;
            third = 1;
            fourth = 1;
            fifth = 0;
            isOutlineEnabled5 = !isOutlineEnabled5;
            isOutlineEnabled2 = false;
            isOutlineEnabled3 = false;
            isOutlineEnabled4 = false;
            isOutlineEnabled1 = false;
        }
        selection1.enabled = isOutlineEnabled1;
        selection2.enabled = isOutlineEnabled2;
        selection3.enabled = isOutlineEnabled3;
        selection4.enabled = isOutlineEnabled4;
        selection5.enabled = isOutlineEnabled5;
    }
}
