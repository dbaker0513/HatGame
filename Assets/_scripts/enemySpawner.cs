
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnX = 5f;
    bool spawned = false;
    public float count = 0f;

    void Update()
    {
        // If no enemies are left and we haven't already spawned one
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0 && !spawned && count < 5)
        {
            spawned = true;
            count += 1;
            float randomY = Random.Range(-2.5f, 3.5f);
            Instantiate(enemyPrefab, new Vector3(spawnX, randomY, 0), Quaternion.identity);
        }

        // Reset the flag once an enemy exists again
        if (GameObject.FindGameObjectsWithTag("Enemy").Length > 0)
        {
            spawned = false;
        }
    }
}

/* using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnX = 8f;
    private List<GameObject> spawnedObjects = new List<GameObject>();

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        if (EnemyController.dead && EnemyController.count < 5) {
            float randomY = Random.Range(-2.5f, 3.5f);
            GameObject enemyPrefab = Instantiate(enemyPrefab, new Vector3(spawnX, randomY, 0), Quaternion.identity);;
        }
        /* else if (EnemyController.dead && EnemyController.count >= 5)
        {
            GameObject BossPrefab = Instantiate(BossPrefab, new Vector3(spawnX, randomY, 0), Quaternion.identity);
        }


    }
    



    // Update is called once per frame
    void Update()
    {
        foreach(GameObject obj in spawnedObjects)
        {
            if (obj != null)
            {
                obj.transform.Translate(Vector2.left * Time.deltaTime * Random.Range(0.1f, 3.0f));
            }
        }
    }
}
*/