using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform Player;
    public float Speed = 3f;
    public int MinDist = 1;
    private PlayerController playerController;
    private float speedTime;
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        speedTime += Time.deltaTime;
       if (speedTime >= 90)
        {
            Speed = 12f;
        }
       else if (speedTime >= 45)
        {
            Speed = 6f;
        }

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * Speed * Time.deltaTime;
        }

        transform.LookAt(Player);
        
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
