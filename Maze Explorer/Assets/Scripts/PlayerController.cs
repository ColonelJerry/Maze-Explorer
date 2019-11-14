﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 9f;
    public float verticalInput;
    public float horizontalInput;
    public int health;
    public TextMeshProUGUI healthText;
<<<<<<< HEAD
<<<<<<< HEAD
    public TextMeshProUGUI gameOverText;
=======
>>>>>>> master
=======
>>>>>>> parent of e584693... Scripting
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        UpdateHealth(0);
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.position += Vector3.forward * verticalInput * Time.deltaTime * speed;

        horizontalInput = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * horizontalInput * Time.deltaTime * speed;

        if (health <= 0)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            gameOverText.text = "Game Over!";
=======
            Debug.Log("Game Over!");
>>>>>>> master
=======
            Debug.Log("Game Over!");
>>>>>>> parent of e584693... Scripting
            Destroy(gameObject);
        }
    }

    public void UpdateHealth(int healthToAdd)
    {
        health += healthToAdd;
        healthText.text = "Health: " + health;
    }
}
