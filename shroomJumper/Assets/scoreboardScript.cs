﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreboardScript : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    public static int coinAmount;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "COINS: " + coinAmount.ToString();
    }
}
