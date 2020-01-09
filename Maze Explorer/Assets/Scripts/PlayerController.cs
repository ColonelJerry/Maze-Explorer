using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float verticalInput;
    public float horizontalInput;
    public int health;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI gameOverText;
    public bool gameOver;
    public GameObject player;
    public GameObject gameOverMenu;


    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        healthText.text = "Health: " + health;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("QUIT!");
            Application.Quit();
        }
        verticalInput = Input.GetAxis("Vertical");
        transform.position += Vector3.forward * verticalInput * Time.deltaTime * speed;

        horizontalInput = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * horizontalInput * Time.deltaTime * speed;

        if (health <= 0)
        {
            player.gameObject.SetActive(false);
            gameOverMenu.gameObject.SetActive(true);
            gameOver = true;
            Debug.Log("GameOver!");
        }
    }

    public void UpdateHealth(int healthToAdd)
    {
        health += healthToAdd;
        healthText.text = "Health: " + health;
    }
}
