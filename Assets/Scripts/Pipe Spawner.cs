using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefeb;

    [SerializeField] private float spawnDelay;
    [SerializeField] private float startDelay;

    public float minY;
    public float maxY;

    private Vector3 spawnPoint;

    private void Start()
    {
        spawnPoint = transform.position;
        InvokeRepeating("SpawnPipe", startDelay, spawnDelay);
    }

    private void SpawnPipe()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(spawnPoint.x, randomY, spawnPoint.z);
        
        Instantiate(pipePrefeb, spawnPos, Quaternion.identity);
    }
}
