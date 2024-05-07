using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float cooldown;
    public GameObject ballPrefab;
    public float spawnOffset;

    private void Start()
    {
        InvokeRepeating("SpawnBall", 0, cooldown);
    }

    public void SpawnBall()
    {
        // random spawn position on X
        float offset = Random.Range(-spawnOffset, spawnOffset);
        Vector3 randomOffset = new Vector3(offset, 0, 0);

        Vector3 spawnPosition = transform.position + randomOffset;
        Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
    }
}
