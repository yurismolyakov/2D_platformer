using System.Security;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracePlayerEffect : MonoBehaviour
{
    public float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public GameObject copy;
    private PlayerController player;

    void Start()
    {
        player = GetComponent<PlayerController>();
    }

    void Update()
    {
        if(!player.IsGround){
            if (timeBtwSpawns <= 0)
        {
            GameObject instance = Instantiate(copy, transform.position, Quaternion.identity);
            Destroy(instance, 8f);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

        }

        

}


