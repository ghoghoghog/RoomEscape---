using UnityEngine;

public class PuzzleButton : MonoBehaviour
{
    public int buttonIndex;  // 버튼의 순서를 나타내는 인덱스
    public button puzzleManager;  // 퍼즐 관리자 스크립트

    private void OnMouseDown()
    {
        // 버튼이 클릭되었을 때의 동작 처리
        puzzleManager.ButtonPressed(buttonIndex);
        Debug.Log("!!!!!!!!!!!!!!!!!!");
    }
}