using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform Player;
    public int Speed = 4;
    public int MaxDist = 10;
    public int MinDist = 1;
    private PlayerController playerController;
<<<<<<< HEAD
<<<<<<< HEAD
    public float elapsedTime;

=======
>>>>>>> master
=======
>>>>>>> parent of e584693... Scripting
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);
        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * Speed * Time.deltaTime;
        }
        if (Vector3.Distance(transform.position, Player.position) <= MaxDist) 
        {
            //
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
