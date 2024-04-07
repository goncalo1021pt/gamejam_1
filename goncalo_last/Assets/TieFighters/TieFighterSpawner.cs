using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TieFighterSpawner : MonoBehaviour
{
    public GameObject TieFighter;
    public float timer = 0;
    public float globaltimer = 0;
    public float  spawnRate = 5;
    void Start()
    {
    }
    void Update()
    {
        if (timer <  spawnRate)
        {
            timer += Time.deltaTime;
            globaltimer += Time.deltaTime;
        }
        else
        {
            spawnTieFighter();
            timer = 0;
            if (globaltimer < 30)
                spawnRate = Random.Range(5, 10);
            else if (globaltimer < 100)
                spawnRate = Random.Range(4, 8);
            else if (globaltimer < 200)
                spawnRate = Random.Range(4, 7);
            else if (globaltimer < 300)
                spawnRate = Random.Range(4, 6);
            else if (globaltimer < 400)
                spawnRate = Random.Range(3, 5);
            else
                spawnRate = 3;
        }  
    }
    void spawnTieFighter()
    {
        Instantiate(TieFighter, new Vector3(transform.position.x + Random.Range(-Camera.main.orthographicSize * 2,Camera.main.orthographicSize * 2), transform.position.y, 0), transform.rotation);
    }
}
