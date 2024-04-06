using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class x_wing : MonoBehaviour
{
	public Rigidbody2D rb;

	public Sprite default_sprite;
	public Sprite shield_sprite;
	public float speed_multi;
	public int hp = 3;
	
	public float shield;
	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		check_buffs();
		if (Input.GetKey(KeyCode.D) && rb.position.x < 34)
			rb.velocity = Vector2.right * speed_multi;
		else if (Input.GetKey(KeyCode.A) && rb.position.x > -34)
			rb.velocity = Vector2.left * speed_multi;
		else 
			rb.velocity = Vector2.zero;
	}

	void check_buffs()
	{
		if (shield > 0)
		{
			shield -= Time.deltaTime;
			if (shield <= 0)
			{
				shield = 0;
				this.gameObject.GetComponent<SpriteRenderer>().sprite = default_sprite;
			}
		}
	}
	/*
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "collectable")
		{
			if ()
			hp = 3;
		
		if ()
		{

			Shoot_2 ammo = GetComponentInChildren<Shoot_2>();
			if (ammo != null)
				ammo.ammo = 5;
		}
		else if ()	
		{
			imunity_shield = true;
			imunity_elapsed_time = 0;
		}
		else if ()
		{
			
		}
		}
		else
		{
			Destroy(gameObject);
		}
	}
*/
}
