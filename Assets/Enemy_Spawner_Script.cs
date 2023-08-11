using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner_Script : MonoBehaviour
{
    [SerializeField]
    private GameObject blobMobPrefab;

    private float mobTimerInterval = 3f;

    void Start()
    {
        StartCoroutine(spawnEnemy(mobTimerInterval, blobMobPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject mob) {

        Camera mainCamera = Camera.main;
        Vector2 bottomLeftPoint = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));
        Vector2 topRightPoint = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, mainCamera.nearClipPlane));
        // Debug.Log(bottomLeftPoint.ToString());


        float spawnAreaPadding = 5.0f;
        Vector2 spawningAreaMax = bottomLeftPoint - new Vector2(spawnAreaPadding, spawnAreaPadding);
        Vector2 spawningAreaMin = topRightPoint + new Vector2(spawnAreaPadding, spawnAreaPadding);

        Vector2 spawnLocation;
        do {
            float randomX = Random.Range(spawningAreaMin.x, spawningAreaMax.x);
            float randomY = Random.Range(spawningAreaMin.y, spawningAreaMax.y);
            spawnLocation = new Vector2(randomX, randomY);
        } while (IsPositionOutsideVisibleArea(bottomLeftPoint, topRightPoint, spawnLocation));
        


        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(mob, spawnLocation, Quaternion.identity);
        newEnemy.GetComponent<blob_script>().mobHP = 30f;
        StartCoroutine(spawnEnemy(interval, blobMobPrefab));
    }

    bool IsPositionOutsideVisibleArea(Vector2 bottomLeft, Vector2 topRight, Vector2 position)
    {
        // Debug.Log("passed in " + bottomLeft + " " + topRight + " " + position);
        if ((position.x >= bottomLeft.x &&
            position.x <= topRight.x) ||
            (position.y >= bottomLeft.y &&
            position.y <= topRight.y))
        {
            // Debug.Log("nop");
            return true;
        }
        else {
            // Debug.Log("bingo");
            return false;
        }
       
    }
}
