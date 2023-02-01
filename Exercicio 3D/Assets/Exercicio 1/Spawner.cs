using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnTimer = 5f;
    public List<GameObject> Walls = new List<GameObject>();

    void Start()
    {
        
    }
    
    float TimeCount;
    // Update is called once per frame
    void Update()
    {
        TimeCount += Time.deltaTime;

        if (TimeCount >= SpawnTimer)
        {
            Instantiate(Walls[Random.Range(0, Walls.Count)], transform.position, transform.rotation);
            TimeCount = 0f;
        }
    }
}
