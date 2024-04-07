using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnCollisionEnter2D(Collision2D colision)
	{
		
		if (colision.gameObject.tag == "Default")
		{
			colision.gameObject.GetComponent<x_wing>().hp -= 3;
		}
	}
}
