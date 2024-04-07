using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Asteroid;
    public  Camera Camera;
    public float timer = 0;
    private float spawnRate;
    public float globaltimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 30;
    }
    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            globaltimer += Time.deltaTime;
            timer += Time.deltaTime;
        }
        else
        {
            spawnAsteroid();
            timer = 0;
            if (globaltimer < 100)
                spawnRate = Random.Range(3, 6);
            else if (globaltimer < 200)
                spawnRate = Random.Range(3, 5);
            else if (globaltimer < 300)
                spawnRate = Random.Range(2, 4);
            else if (globaltimer < 400)
                spawnRate = Random.Range(1, 3);
            else
                spawnRate = 1;
        }
    }
    void spawnAsteroid()
    {
        Instantiate(Asteroid, new Vector3(transform.position.x + Random.Range(-Camera.main.orthographicSize * 2,Camera.main.orthographicSize * 2), transform.position.y, 0), transform.rotation);
    }
}
