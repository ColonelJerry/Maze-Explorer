﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TheEnd : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(GameObject.Find("Ghost"));
        gameOverText.text = "You Win!";
    }
}
