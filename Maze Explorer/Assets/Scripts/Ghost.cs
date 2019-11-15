﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform Player;
    public float Speed = 1;
    public int MinDist = 1;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Time.time >= 10)
        {
            Speed = 3.5f;
        }
       else if (Time.time >= 5)
        {
            Speed = 2.6f;
        }

        transform.LookAt(Player);
        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * Speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (playerController.health > 1)
        {
            playerController.UpdateHealth(-1);
            transform.position = new Vector3(25, 1, 0);
        }
        else
            {
            playerController.UpdateHealth(-1);
        }
    }
}