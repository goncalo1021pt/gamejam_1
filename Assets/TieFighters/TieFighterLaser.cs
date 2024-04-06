using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TieFighterLaser : MonoBehaviour
{
    public Rigidbody2D Laser;
    // Start is called before the first frame update
    void Start()
    {
        Laser.velocity = Vector2.down * 30;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        other.gameObject.GetComponent<x_wing>().hp--;
        if (other.gameObject.GetComponent<x_wing>().hp == 0)
            Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
