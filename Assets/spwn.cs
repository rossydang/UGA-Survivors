using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwn : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawn = false;
    public float spawnInterval;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMush", spawnInterval, spawnDelay);
    }

    // Update is called once per frame
    public void SpawnMush() {
        Instantiate(spawnee, transform.position, transform.rotation);
        if(stopSpawn) {
            CancelInvoke("SpawnMush");
        }
    }
}
