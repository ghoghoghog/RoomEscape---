using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventory;
    public bool current = (false);

    private void Start()
    {
        inventory.SetActive(current);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            current = !current;
            inventory.SetActive(current);
        }
    }
}
