using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
	public Rigidbody2D	body;
	public GameObject	laser;
    // Start is called before the first frame update
    void Start()
    {
        body.velocity = Vector2.right * 10;
    }

    // Update is called once per frame
    void Update()
    {
        BossMoviment();
		BossAtack();
    }

	private void BossMoviment()
	{
		if(transform.position.x > 30)
			 body.velocity = Vector2.left * 10;
		else if(transform.position.x < -30)
			 body.velocity = Vector2.right * 10;
	}

	private void BossAtack()
	{
		Vector2 save;
		float	time;

		if (Random.Range(1, 100) != 69)
			return;
		save = body.velocity;
		time = 0;
		body.velocity = Vector2.right * 0;
		Instantiate(laser, transform.position, transform.rotation);
		while(time < 3)
		{
			time += Time.deltaTime;
		}
		Destroy(laser);
		body.velocity = save;
	}
}
