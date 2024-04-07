using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TieFighterLaser : MonoBehaviour
{
    public Rigidbody2D Laser;
    // Start is called before the first frame update
    void Start()
    {
        Laser.velocity = Vector2.down * 20;
    }

    // Update is called once per frame
    void Update()
    {
		if(transform.position.y < -Camera.main.orthographicSize - 2)
			Death();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Death();
    }

	private void	Death()
	{
		Destroy(gameObject);
	}
}
