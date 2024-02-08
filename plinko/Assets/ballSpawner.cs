using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballSpawner : MonoBehaviour
{

    public GameObject ballPrefab;

    public Transform spawnTransform;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = spawnTransform.position;
        spawnPosition.z += Random.Range(-8f, 8f);
        Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPosition = spawnTransform.position;
            spawnPosition.z += Random.Range(-8f, 8f);
            Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
