using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextroom1 : MonoBehaviour
{
    public GameObject maincamera;
    private void OnMouseDown()
    {
        {
            maincamera.transform.Translate(0,0,220);
        }
    }
}
