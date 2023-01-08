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

        print(spawnPointPosition.y);
        base.Update();
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (allPlatforms.Count == 0)
            {
                SpawnPlatform(platform, new Vector2(0, spawnPointPosition.y));
            }
            else
            {
                foreach(Platform platform in allPlatforms)
                {
                    if(platform.transform.position.y == spawnPointPosition.y)
                    {
                        print("Cannot place here");
                        positionTaken = true;
                    }
                    else
                    {
                        positionTaken = false;
                    }
                }

                if (!positionTaken)
                    SpawnPlatform(platform, new Vector2(0, spawnPointPosition.y));  
            }
        }
    }

    void SpawnPlatform(GameObject prefab, Vector2 objPos)
    {

        GameObject platformObj = Instantiate(prefab);
        Platform myPlatform = platformObj.GetComponent<Platform>(); 
        myPlatform.transform.position = objPos;
        allPlatforms.Add(myPlatform);
    }
}
