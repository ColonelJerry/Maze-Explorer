using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform Player;
    public float Speed = 1;
    public int MinDist = 1;
    private PlayerController playerController;
    public float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime >= 10)
        {
            Speed = 3.5f;
        }
        else if (elapsedTime >= 5)
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
        elapsedTime = 0.0f;
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
