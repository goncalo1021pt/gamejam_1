using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missle_move : MonoBehaviour
{
	public Rigidbody2D			body;
	public BulletData			data;
    // Start is called before the first frame update
    void Start()
    {
        body.velocity = Vector2.up * data.y_direction * data.velocity;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > Camera.main.orthographicSize + 2)
			 Destroy(gameObject);
    }
	private void OnCollisionEnter2D(Collision2D colision)
	{
		Destroy(gameObject);
	}
}
