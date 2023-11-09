using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    public static bool isCollected = false;

    private void Awake()
    {
        GlobalEventManager.OnCollected.AddListener(Collect);
        GlobalEventManager.OnDiscard.AddListener(Discard);
    }

    void Collect()
    {
        isCollected = true;
    }

    void Discard()
    {
        isCollected = false;
    }

    private void Update()
    {
        
    }
}
