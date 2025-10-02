using UnityEditor.Rendering;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.5f;
    [SerializeField] private GameObject _pipe;

    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    void SpawnPipe()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPosition, Quaternion.identity);

        Destroy(pipe, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
