using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.rotation.eulerAngles.x==0)
            {
                transform.Rotate(0,90,0);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.rotation.eulerAngles.x==0)
            {
                transform.Rotate(0,-90,0);
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (transform.rotation.eulerAngles.x !=(270))
            {
                transform.Rotate(-90,0,0);
              //  transform.rotation = Quaternion.Euler(new Vector3());
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (transform.rotation.eulerAngles.x !=(90))
            {
              transform.Rotate(90, 0, 0);  
            }
            
        }
        
    }
}
