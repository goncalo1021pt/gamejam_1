using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VultureSpawner : MonoBehaviour
{
    public GameObject Vulture;
    public float timer = 0;
    public float spawnRate = 100;

    public float globaltimer = 0;
    void Start()
    {
    }
    void Update()
    {
        if (timer < spawnRate)
        {
            globaltimer += Time.deltaTime;
            timer += Time.deltaTime;
        }
        else
        {
            spawnVulture();
            timer = 0;
            if (globaltimer < 200)
                spawnRate = Random.Range(20, 25);
            else if (globaltimer < 400)
                spawnRate = Random.Range(14, 16);
            else
                spawnRate = Random.Range(8, 12);
        } 
    }
    void spawnVulture()
    {
        Instantiate(Vulture, new Vector3(transform.position.x + Random.Range(-Camera.main.orthographicSize * 2,Camera.main.orthographicSize * 2), transform.position.y, 0), transform.rotation);
    }
}
