using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomCarSpawner : MonoBehaviour
{
    [SerializeField] Mover[] prefabToSpawn;
   // [SerializeField] Vector3 velocityOfSpawnedObject;
    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 1f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 3f;

    void Start()
    {
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            int carType = Random.Range(0, prefabToSpawn.Length);
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z);
            print(transform.position);
            GameObject newObject = Instantiate(prefabToSpawn[carType].gameObject, positionOfSpawnedObject, Quaternion.identity);
            //newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
        }
    }
}
