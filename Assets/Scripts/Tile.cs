using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    private TextMeshProUGUI textNumberic;

    private int numberic;

    public int Numberic
    {
        set
        {
            numberic = value;
            textNumberic.text = numberic.ToString();
        }
        get => numberic;
    }

    public void Setup(int hideNumberic, int numberic)
    {
        textNumberic = GetComponentInChildren<TextMeshProUGUI>();

        Numberic = numberic;
        if (Numberic==hideNumberic)
        {
            GetComponent<UnityEngine.UI. Image>().enabled = false;
            textNumberic.enabled = false;
        }
    }
}
