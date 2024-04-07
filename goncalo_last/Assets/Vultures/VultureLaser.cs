using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ola : MonoBehaviour
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
        if (transform.position.y < -Camera.main.orthographicSize - 2)
            Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player" && other.gameObject.GetComponent<x_wing>().shield == 0)
            other.gameObject.GetComponent<x_wing>().hp--;
        Destroy(gameObject);
    }
}
