using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform Player;
    public float Speed = 1.5f;
    public int MinDist = 1;
    private PlayerController playerController;
    //private float genTime;
    //private float clock;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        //genTime = clock;
    }

    // Update is called once per frame
    void Update()
    {
       if (Time.time >= 10)
        {
            Speed = 6f;
        }
       else if (Time.time >= 5)
        {
            Speed = 3f;
        }

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * Speed * Time.deltaTime;
        }

        transform.LookAt(Player);
        //clock = Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (playerController.health > 1)
        {
            playerController.UpdateHealth(-1);
            transform.position = new Vector3(25, 1, 0);
            //genTime = clock - clock;
        }
        else
        {
            playerController.UpdateHealth(-1);
        }
    }
}
