using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{

   
    
    public GameObject door1;
    private void OnMouseDown()
    {
        if (KeyManager.key >= 1)
        {
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("열쇠가 필요하다");
        }
    }
}
