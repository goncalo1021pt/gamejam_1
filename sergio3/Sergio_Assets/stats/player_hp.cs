using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_hp : MonoBehaviour
{
	public Sprite hp1;
	public Sprite hp2;
	public Sprite hp3;
	public Sprite hp4;
	public Sprite hp5;
	private x_wing x_Wing;

	public int hp = 5;
	// Start is called before the first frame update
	void Start()
	{
		x_Wing = FindAnyObjectByType<x_wing>();
	}

	// Update is called once per frame
	void Update()
	{
		set_hp(x_Wing.hp);
	}

	public void set_hp(int hp)
	{
		if (hp == 5)
			GetComponent<SpriteRenderer>().sprite = hp5;
		else if (hp == 4)
			GetComponent<SpriteRenderer>().sprite = hp4;
		else if (hp == 3)
			GetComponent<SpriteRenderer>().sprite = hp3;
		else if (hp == 2)
			GetComponent<SpriteRenderer>().sprite = hp2;
		else
			GetComponent<SpriteRenderer>().sprite = hp1;
	}
}
