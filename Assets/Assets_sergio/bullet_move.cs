using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public Rigidbody2D			body;
	public BulletData			data;
	public const float			screenTop = 20;
    // Start is called before the first frame update
    void Start()
    {
		body.velocity = Vector2.up * data.y_direction * data.velocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= screenTop)
		{
			Destroy(gameObject);
		}
    }

	private void OnCollisionEnter2D(Collision2D colision)
	{
		Destroy(gameObject);
	}
}
