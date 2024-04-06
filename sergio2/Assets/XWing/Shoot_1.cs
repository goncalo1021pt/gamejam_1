using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_1 : MonoBehaviour
{
	public GameObject	Bullet;
  public float RateOfFire = 1f;
	public float		timer = 1;
  public float RoFtimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(timer < RateOfFire)
			timer += Time.deltaTime;
    else if (Input.GetKey(KeyCode.Space))
		{
			Instantiate(Bullet, transform.position, transform.rotation);
			timer = 0;
		}
    if (RateOfFire < 1)
      RoFtimer += Time.deltaTime;
    if (RoFtimer > 30)
    {
      RoFtimer = 0;
      RateOfFire = 1f;
    }
    }
}
