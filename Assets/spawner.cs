using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
	public GameObject hp;
	public GameObject bullet;
	public GameObject shield;
	public GameObject bomb;
	public float spawn_time ;
	public int x_offset = 30;
	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		spawn_collectable(hp);
		spawn_collectable(bullet);
		spawn_collectable(shield);
		spawn_collectable(bomb);
	}

	void spawn_collectable(GameObject collectable)
	{
		float x_position;
		float spawn_Rate = Random.Range(15, 30);

		if (spawn_time < spawn_Rate)
		{
			spawn_time += Time.deltaTime;
		}
		else
		{
			x_position = Random.Range(-x_offset, x_offset);
			Instantiate(collectable, new Vector3 (x_position, transform.position.y, 0), transform.rotation);
			spawn_time = 0;
		}
	}

}
