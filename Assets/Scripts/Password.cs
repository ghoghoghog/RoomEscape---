using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Password : MonoBehaviour
{
    [SerializeField] private TMP_InputField password;
    public string correctPassword = "1234"; // 올바른 비밀번호 설정

    
    
    public void OnEndEditEvent()
    {
        string inputPassword = password.text;
        if (inputPassword == correctPassword)
        {
            KeyManager.key1 = 1;
            Destroy(password.gameObject);
        }
        else
        {
           Debug.Log("비밀번호가 틀렸습니다");
        }
        
    }
}
