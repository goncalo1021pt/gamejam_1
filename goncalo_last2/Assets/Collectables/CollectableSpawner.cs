using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
	public GameObject hp;
	public GameObject bullet;
	public GameObject shield;
	public GameObject bomb;
	public float spawn_time = 0;
	private float spawn_Rate;
	public int x_offset = 30;
	// Start is called before the first frame update
	void Start()
	{
		spawn_Rate = Random.Range(15, 30);
	}

	// Update is called once per frame
	void Update()
	{
		if (spawn_time < spawn_Rate)
			spawn_time += Time.deltaTime;
		else
		{
			int which;
			which = Random.Range(0, 4);
			if (which == 0)
				spawn_collectable(hp);
			else if (which == 1)
				spawn_collectable(bullet);
			else if (which == 2)
				spawn_collectable(shield);
			else
				spawn_collectable(bomb);
			spawn_time = 0;
			spawn_Rate = Random.Range(15, 30);			
		}

	}

	void spawn_collectable(GameObject collectable)
	{
		float x_position;

		x_position = Random.Range(-x_offset, x_offset);
		Instantiate(collectable, new Vector3 (x_position, transform.position.y, 0), transform.rotation);
		spawn_time = 0;
	}

}
