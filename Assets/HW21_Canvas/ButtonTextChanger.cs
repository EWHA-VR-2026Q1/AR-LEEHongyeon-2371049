using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonTextChanger : MonoBehaviour
{
    // 버튼의 자식 텍스트를 담을 변수
    public TextMeshProUGUI buttonText;

    // 버튼을 눌렀을 때 실행될 함수
    public void ChangeText()
    {
        if (buttonText != null)
        {
            buttonText.text = "Button is Cliked";
        }
    }
}
