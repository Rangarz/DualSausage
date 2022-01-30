using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> ObjectsToSpawn;


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnObject", 1f, Random.Range(1f, 3f));
    }

    void SpawnObject()
    {
        Instantiate(ObjectsToSpawn[Random.Range(0, ObjectsToSpawn.Count)], gameObject.transform.position, gameObject.transform.rotation);
    }
}
