using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public Vector3 spawnPos = new Vector3(0, 0, 25);
    public int animalIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(animalPrefabs[0], spawnPos, animalPrefabs[0].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
