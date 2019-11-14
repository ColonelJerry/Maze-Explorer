﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Clock : MonoBehaviour
{
    private float startTime;
    private PlayerController playerController;
    public TextMeshProUGUI timeText;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.health <= 0)
        {
            return;
        }
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");

        timeText.text = "Time: "+ minutes + "Min " + seconds + "Sec";
    }
}
