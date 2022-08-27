using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstacle : MonoBehaviour
{
    [SerializeField] private float timeStart = 0;
    [SerializeField] private int per_second_increment = 10;
    public GameObject[] obstaclePrefab;
    public float respawnTime = 6.9f;
    private Vector2 screenBounds;
    private int random_number;
    [SerializeField] private float small_spawn;
    [SerializeField] private float tall_spawn = -3.1f;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
        Debug.Log(screenBounds.x * -2);
    }

    void Update()
    {
        timeStart += Time.deltaTime;

        if (timeStart >= per_second_increment && respawnTime > 1f)
        {
            timeStart = 0f;
            Debug.Log("timeStart: " + Mathf.Round(timeStart));
            respawnTime -= 0.06f;
            Debug.Log("respawn_time: " + respawnTime);
        }
    }

    private void spawnEnemy()
    {
        random_number = Random.Range(0, 2);
        GameObject a = Instantiate(obstaclePrefab[random_number]) as GameObject;
        if(random_number == 0) {
            a.transform.position = new Vector2(12, small_spawn);
        }
        else {
            a.transform.position = new Vector2(12, tall_spawn);
        }
    }
    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
