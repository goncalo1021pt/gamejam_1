using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
	public Rigidbody2D	body;
	public GameObject	laser;
	public GameObject	windup;
	private GameObject	Ilaser;
	private GameObject	Iwindup;
	private float		cooldown = 0;
	private float		starttime = 0;
	private bool		attack_on = false;
	private bool		attack_prep = false;
	private bool		start = true;
	public	int			hp;
	public float		speed;
    // Start is called before the first frame update
    void Start()
    {
		hp = 50;
		body.velocity = Vector2.down * 2;
    }

    // Update is called once per frame
    void Update()
    {
		if (starttime > 5)
		{
			if (start)
			{
				body.velocity = Vector2.right * speed;
				start = false;
				cooldown = 0;
			}
			if (attack_on == false)
				BossMoviment();
			BossAtack();
			if (hp < 1)
				Death();
		}
		else
			starttime += Time.deltaTime;
    }

	private void BossMoviment()
	{
		if(transform.position.x > 30)
			 body.velocity = Vector2.left * speed;
		else if(transform.position.x < -30)
			 body.velocity = Vector2.right * speed;
	}


	
	private void BossAtack()
	{
		if (attack_prep == true)
		{
			if (cooldown < 2)
				cooldown += Time.deltaTime;
			else
			{
				Destroy(Iwindup);
				Ilaser = Instantiate(laser, transform.position + Vector3.down * 38  + Vector3.left * 0.5f, laser.transform.rotation);
				attack_prep = false;
				attack_on = true;
			}
		}
		else if (attack_on == true)
		{
			if (cooldown > 6)
			{
				Destroy(Ilaser);
				body.velocity = Vector2.left * speed;
				attack_on = false;
			}
			else
				cooldown += Time.deltaTime;
		}
		else if (cooldown < 14)
			cooldown += Time.deltaTime;
		else if (Random.Range(1, 50) == 1)
		{
			body.velocity = Vector2.zero;
			attack_prep = true;
			cooldown = 0;
			Iwindup = Instantiate(windup, transform.position + Vector3.down * 19 + Vector3.left * 0.5f, laser.transform.rotation);
		}
	}

	private void Death()
	{
		if(Ilaser)
			Destroy(Ilaser);
		if(Iwindup)
			Destroy(Iwindup);
		Destroy(gameObject);
	}
}
