using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBirds : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bird;

    float lifetime = 0;
    float spawnTimer = 5;
    int birdsspawned = 0;

    int maxbirdsspawned = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifetime += Time.deltaTime;
        spawnTimer -= Time.deltaTime;
        
        if (spawnTimer < 0 && birdsspawned < maxbirdsspawned)
        {
            spawnTimer = 5;
            //spawn bird
            GameObject bird = new GameObject();

            bird = Instantiate(Bird, transform.position + new Vector3(0, 0.25f, 0), transform.rotation) as GameObject;
            birdsspawned++;
        }
    }
}
