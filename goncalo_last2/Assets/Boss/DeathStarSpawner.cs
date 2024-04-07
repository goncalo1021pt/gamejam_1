using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathStarSpawner : MonoBehaviour
{
    public GameObject DeathStar;
    public float timer = 0;
    public float BossTime = 400;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(DeathStar, DeathStar.transform.position, DeathStar.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < BossTime)
            timer += Time.deltaTime;
        else   
        {
            Instantiate(DeathStar, DeathStar.transform.position, DeathStar.transform.rotation);
            timer = 0;
        }
    }
}
