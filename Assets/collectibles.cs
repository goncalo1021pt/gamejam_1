using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp_script : MonoBehaviour
{
	public Rigidbody2D rb;
	public float speed_multi;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		rb.velocity = Vector2.down * speed_multi;
		if (rb.position.y < -20)
		{
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		Destroy(gameObject);
	}
}
