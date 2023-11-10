    using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    public TextMeshProUGUI delivered;

    private void Update()
    {
        if (Boat.isCollected)
        {
            delivered.text = "Collected";
        }
        else
        {
            delivered.text = "Boat Empty";
        }
    }
}
