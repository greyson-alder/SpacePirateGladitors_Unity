using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy_Spawner_Script : MonoBehaviour
{
    [SerializeField]
    private GameObject blobMobPrefab;

    private float mobTimerInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(mobTimerInterval, blobMobPrefab));
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float interval, GameObject mob) { 
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(mob, new Vector3(10, 10, 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, newEnemy));
    }
}
