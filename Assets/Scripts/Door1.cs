using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    private Key key;
    
    private void OnMouseDown()
    {
        if (KeyManager.key1 == 1 )
        {
            if ( Key.first == 0)
            {
                KeyManager.key1 = 0;
               Destroy(gameObject);
                
            }
            else
            {
                Debug.Log("가지고 있는 열쇠를 써보자");
            }
        }
        else
        {
            Debug.Log("열쇠가 필요하다");
        }
    }
}
