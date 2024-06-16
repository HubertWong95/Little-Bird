using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;

    public float heightOffset = 10;
    public float spawnRate = 4;
    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        pipeSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            pipeSpawn();
            timer = 0;
            spawnRate = Random.Range(2, 4);
        }
    }

    void pipeSpawn()
    {
        float lowestHeight = transform.position.y - heightOffset;
        float highestHeight = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestHeight, highestHeight), 0), transform.rotation);
    }
}
