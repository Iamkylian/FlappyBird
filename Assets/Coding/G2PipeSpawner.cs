using UnityEngine;

public class G2PipeSpawner : MonoBehaviour
{

    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float spawnHeight = 3f;
    private float nextSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextSpawn = Time.time + spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnPipe();
        }
    }

    void SpawnPipe()
    {
        float spawnY = Random.Range(-spawnHeight, spawnHeight);
        Vector3 spawnPosition = new Vector3(transform.position.x, spawnY, transform.position.z);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
