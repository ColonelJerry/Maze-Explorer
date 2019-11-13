using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform Player;
    public int Speed = 4;
    public int MaxDist = 10;
    public int MinDist = 1;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
