using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public Rigidbody2D Asteroid;
    public GameObject AsteroidBreak;
    public Camera Camera;
    // Start is called before the first frame update
    void Start()
    {
        Asteroid.velocity = Vector2.down * Random.Range(5, 15) + Vector2.right * Random.Range(-1, 1);
        Asteroid.angularVelocity = Random.Range(-100, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -Camera.main.orthographicSize - 5)
            Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
		if (other.gameObject.CompareTag("Default"))
		{
        	other.gameObject.GetComponent<x_wing>().hp--;
		}
        Destroy(gameObject);
    }
    void OnDestroy()
    {
        Instantiate(AsteroidBreak, transform.position, transform.rotation);
    }
}
