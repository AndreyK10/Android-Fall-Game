using System.Collections;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] platforms;
    [SerializeField] private float spawnDelay = 2f;
    [SerializeField] private float minX, maxX;
    [SerializeField] private Transform platformsContainer;



    private void Start()
    {
        StartCoroutine(SpawnPlatforms());
    }

    private IEnumerator SpawnPlatforms()
    {
        Vector3 spawnPos = transform.position;
        spawnPos.x = Random.Range(minX, maxX);        
        Instantiate(platforms[Random.Range(0, platforms.Length)], spawnPos, Quaternion.identity, platformsContainer);
        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine(SpawnPlatforms());
    }




}
