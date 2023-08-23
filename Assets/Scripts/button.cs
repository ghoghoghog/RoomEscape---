using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public GameObject[] buttons;  // 연결된 버튼들
    public GameObject door;  // 열릴 문(도어 등)
    public int[] correctButtonOrder;  // 올바른 버튼 순서 배열

    private int buttonPressIndex = 0;  // 현재까지 눌린 버튼 수

    public void ButtonPressed(int buttonIndex)
    {
        if (buttonIndex == correctButtonOrder[buttonPressIndex])
        {
            buttonPressIndex++;
            Debug.Log(buttonPressIndex);

            if (buttonPressIndex == correctButtonOrder.Length)
            {
                OpenDoor();  // 올바른 순서로 모든 버튼을 눌렀을 때 동작
            }
        }
        else
        {
            // 잘못된 순서로 버튼을 눌렀을 때의 처리
            ResetPuzzle();
        }
    }

    private void OpenDoor()
    {
        door.SetActive(false);  // 문을 열기
    }

    private void ResetPuzzle()
    {
        buttonPressIndex = 0;  // 퍼즐 초기화
        // 추가적인 초기화 동작 처리
    }
}
