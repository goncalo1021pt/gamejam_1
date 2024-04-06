using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Asteroid;
    public  Camera Camera;
    public float timer = 0;
    private float timesup;
    // Start is called before the first frame update
    void Start()
    {
        timesup = Random.Range(0, 3);
    }
    // Update is called once per frame
    void Update()
    {
        if (timer < timesup)
            timer += Time.deltaTime;
        else
        {
            spawnAsteroid();
            timer = 0;
            timesup = Random.Range(0, 3);
        }
    }
    void spawnAsteroid()
    {
        Instantiate(Asteroid, new Vector3(transform.position.x + Random.Range(-Camera.main.orthographicSize * 2,Camera.main.orthographicSize * 2), transform.position.y, 0), transform.rotation);
    }
}
