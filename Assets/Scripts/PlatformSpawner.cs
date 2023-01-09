using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : SpawnPoint
{

    public GameObject platform;

    public HashSet<Platform> allPlatforms;
    bool positionTaken;

    private void Awake()
    {
        allPlatforms = new HashSet<Platform>();
        positionTaken = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        
        base.Update();

        if (allPlatforms.Count == 0)
        {
             if (Input.GetKeyDown(KeyCode.S))
                SpawnPlatform(platform, new Vector3(0, spawnPointPosition.y, spawnPointPosition.z));
        }
        else
        {
            //Check if position is taken when attempting to spawn.
            if (Input.GetKeyDown(KeyCode.S))
            {
                foreach (Platform platform in allPlatforms)
                {

                    if (platform.transform.position.y == spawnPointPosition.y)
                    {
                        print("Cannot place here");
                        positionTaken = true;
                    }
                }

                //If position is free, spawn it.
                if(!positionTaken)
                    SpawnPlatform(platform, new Vector3(0, spawnPointPosition.y, spawnPointPosition.z));
            }

            positionTaken = false;
         }
    }

    void SpawnPlatform(GameObject prefab, Vector3 objPos)
    {
        GameObject platformObj = Instantiate(prefab);
        Platform myPlatform = platformObj.GetComponent<Platform>(); 
        myPlatform.transform.position = objPos;
        allPlatforms.Add(myPlatform);
    }
}
