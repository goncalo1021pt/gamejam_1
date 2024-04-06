using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_1 : MonoBehaviour
{
	public GameObject	Bullet;
	public float		timer = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(timer < 0.2)
			timer += Time.deltaTime;
        else if (Input.GetKey(KeyCode.Q))
		{
			Instantiate(Bullet, transform.position, transform.rotation);
			timer = 0;
		}
    }
}
