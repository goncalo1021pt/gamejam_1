using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_2 : MonoBehaviour
{
	public GameObject	Bullet;
	public float		timer = 2;
	public int			ammo = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(timer < 2)
			timer += Time.deltaTime;
        else if (Input.GetKey(KeyCode.LeftShift) && ammo > 0)
		{
			Instantiate(Bullet, transform.position, transform.rotation);
			ammo--;
			timer = 0;
		}
    }
}
