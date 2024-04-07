using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterGun : MonoBehaviour
{
    public float timer = 0;
    public float RateOfFire = 1;
    public GameObject Laser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < RateOfFire)
            timer += Time.deltaTime;
        else
        {
            Instantiate(Laser, transform.position, transform.rotation);
            timer = 0;
        }
    }
}
