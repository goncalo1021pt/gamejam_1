using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class x_wing : MonoBehaviour
{
	public Rigidbody2D rb;
	public float speed_multi;
	public int hp = 3;
	
	public float shield;
	public float shield_hp = 5;
	public Sprite deault_sprite;
	public Sprite shield_sprite;
	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		check_buffs();
		check_death();
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
		}
		else
		{
			GetComponent<SpriteRenderer>().sprite = deault_sprite;
			shield = 0;
			shield_hp = 5;
		}
	}

	void	check_death()
	{
		if (hp < 1)
			Destroy(gameObject);
	}
	
	void OnCollisionEnter2D(Collision2D other)
	{
		if (shield > 0)
		{
			shield_hp -= 1;
			if (shield_hp < 1)
			{
				shield = 0;
				GetComponent<SpriteRenderer>().sprite = deault_sprite;
			}
		}
	}
}
