using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TieFighterSpawner : MonoBehaviour
{
    public GameObject TieFighter;
    public float timer = 0;
    void Start()
    {
    }
    void Update()
    {
        if (timer < 5)
            timer += Time.deltaTime;
        else
        {
            spawnTieFighter();
            timer = 0;
        }  
    }
    void spawnTieFighter()
    {
        Instantiate(TieFighter, new Vector3(transform.position.x + Random.Range(-Camera.main.orthographicSize * 2,Camera.main.orthographicSize * 2), transform.position.y, 0), transform.rotation);
    }
}
