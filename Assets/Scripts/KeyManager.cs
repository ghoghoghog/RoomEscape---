using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public static int key1 = 0;
    public GameObject key1image;
    public static int key2 = 0;
    public GameObject key2image;
    public static int key3 = 0;
    public GameObject key3image;
    public static int key4 = 0;
    public GameObject key4image;
    public static int key5 = 0;
    public GameObject key5image;

    private void Start()
    {
        key1image.SetActive(false);
        key2image.SetActive(false);
        key3image.SetActive(false);
        key4image.SetActive(false);
        key5image.SetActive(false);
    }

    private void Update()
    {
        if (key1==1)
        {
            key1image.SetActive(true);
        }
        else
        {
           key1image.SetActive(false); 
        }
        if (key2==1)
        {
            key2image.SetActive(true);
        }
        else
        {
            key2image.SetActive(false);
        }
        if (key3==1)
        {
            key3image.SetActive(true);
        }
        else
        {
         key3image.SetActive(false);   
        }
        if (key4==1)
        {
            key4image.SetActive(true);
        }
        else
        {
            key4image.SetActive(false);
        }
        if (key5==1)
        {
            key5image.SetActive(true);
        }
        else
        {
            key5image.SetActive(false);
        }
    }
}
