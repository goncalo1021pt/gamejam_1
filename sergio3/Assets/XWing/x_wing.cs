using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Side
{

	public class sidef
    {
		public static int side = 0;

		public static int choseSide(int i)
		{
			if (side == 0)
			{
				side = i;
			}
			return(side);
		}
	}
}

public class x_wing : MonoBehaviour
{
	public Rigidbody2D rb;
	public float speed_multi;
	public int hp = 3;
	
	public float shield;
	public float shield_hp = 5;
	public Sprite deault_sprite;
	public Sprite shield_sprite;
	public Sprite dark;
	public Sprite Sdark;
	public Sprite light;
	public Sprite Slight;
	private int	side = 0;
	// Start is called before the first frame update
	void Start()
	{
		Side.sidef.choseSide(2);
		side = Side.sidef.choseSide(0);
		SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
		if (side == 1)
		{
			deault_sprite = light;
			shield_sprite = Slight;
		}
		else
		{
			deault_sprite = dark;
			shield_sprite = Sdark;
		}
		GetComponent<SpriteRenderer>().sprite = deault_sprite;
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
	
	private void OnCollisionEnter2D(Collision2D colision)
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
