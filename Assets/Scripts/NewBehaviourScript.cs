using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject hiddenButton; // 연결된 숨겨진 버튼

    private bool buttonActivated = false;
    private void OnMouseDown()
    {
        if (buttonActivated)
        {
            DeactivateButton();
        }
        else
        {
            ActivateButton();
        }
    }

    private void ActivateButton()
    {
        hiddenButton.SetActive(true); // 숨겨진 버튼 활성화
        buttonActivated = true;
    }

    private void DeactivateButton()
    {
        hiddenButton.SetActive(false); // 숨겨진 버튼 비활성화
        buttonActivated = false;
    }
}
