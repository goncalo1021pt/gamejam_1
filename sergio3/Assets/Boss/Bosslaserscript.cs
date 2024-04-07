using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosslaserscript : MonoBehaviour
{
	public	Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
/*
	void OnCollisionEnter2D(Collision2D colision)
	{
		print("OLA");
		Debug.Log("Collision Detected with: " + colision.gameObject.name);
		if (cooldown < 0.2)
			cooldown += Time.deltaTime;
		else
		{
			if (colision.gameObject.tag == "Default")
			{
				if(colision.gameObject.GetComponent<x_wing>().imunity_shield == false)
        			colision.gameObject.GetComponent<x_wing>().hp -= 3;
				cooldown = 0;
			}
		}
	}*/
}
