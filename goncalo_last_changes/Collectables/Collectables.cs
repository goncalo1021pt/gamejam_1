using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp_script : MonoBehaviour
{
	public Rigidbody2D rb;
	public float speed_multi = 1;
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
		if (gameObject.tag == "HP")
			other.gameObject.GetComponent<x_wing>().hp = 3;
		else if (gameObject.tag == "Ammo")
		{
			other.gameObject.GetComponentInChildren<Shoot_1>().RateOfFire /= 5f;
			other.gameObject.GetComponentInChildren<Shoot_1>().RoFtimer = 0;
		}
		else if (gameObject.tag == "Shield")	
		{
			other.gameObject.GetComponent<x_wing>().shield = 20;
			other.gameObject.GetComponent<SpriteRenderer>().sprite = other.gameObject.GetComponent<x_wing>().shield_sprite;
		}
		else if (gameObject.tag == "Bomb")
		{
			GameObject[] Enemies = GameObject.FindGameObjectsWithTag("Enemy");
			foreach (GameObject enemy in Enemies)
            	Destroy(enemy);
			GameObject[] lasers = GameObject.FindGameObjectsWithTag("EnemyFire");
			foreach (GameObject laser in lasers)
           		Destroy(laser);
		}
		Destroy(gameObject);
	}
}
