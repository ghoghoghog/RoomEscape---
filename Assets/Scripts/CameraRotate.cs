using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.rotation.eulerAngles.x==0)
            {
                transform.Rotate(0,90,0);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.rotation.eulerAngles.x==0)
            {
                transform.Rotate(0,-90,0);
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow ))
        {
            if (transform.rotation.eulerAngles.x ==90 || transform.rotation.eulerAngles.x ==0)
            {
                transform.Rotate(-90,0,0);
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Rotate(90, 0, 0);
        }
        
    }
}
