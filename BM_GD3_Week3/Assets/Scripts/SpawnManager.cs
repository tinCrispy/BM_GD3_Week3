using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float[] spawnPositionX;
    public int spawnPositionZ = -1;

    private float startDelay = 2;
    private float spawnInterval = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnAnimal()
    {     
            int spawnIndexX = Random.Range(0, spawnPositionX.Length);
            Vector3 spawnPos = new Vector3(spawnPositionX[spawnIndexX], 0, spawnPositionZ);
            int animalIndex = (Random.Range(0, animalPrefabs.Length));
            Instantiate(animalPrefabs[animalIndex], spawnPos,
                                        animalPrefabs[animalIndex].transform.rotation);
    }

}
