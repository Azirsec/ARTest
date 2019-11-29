﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBirds : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bird;
    public GameObject Dog;
    public GameObject forest;

    public Bush[] bushes = new Bush[24];

    float lifetime = 0;
    float spawnTimer = 5;
    int birdsspawned = 0;

    //int maxbirdsspawned = 3;

    int selectedBush;

    void Start()
    {
        bushes = forest.GetComponentsInChildren<Bush>();
    }

    // Update is called once per frame
    void Update()
    {
        lifetime += Time.deltaTime;
        spawnTimer -= Time.deltaTime;

        if (spawnTimer < 0)// && birdsspawned < maxbirdsspawned)
        {
            spawnTimer = 5;

            int thingToSpawn = Random.Range(0, 10);

            if (thingToSpawn < 9)
            {
                //spawn bird
                selectedBush = Random.Range(0, 24);
                bushes[selectedBush].spawnBird(Bird);
                birdsspawned++;
            }

            //spawn doge
            else
            {
                selectedBush = Random.Range(0, 24);
                bushes[selectedBush].spawnDog(Dog);
            }

        }
    }
}
