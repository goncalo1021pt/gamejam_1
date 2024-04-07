using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VultureMotion : MonoBehaviour
{
    public Rigidbody2D Vulture;
    public float VultureVelocity = 1f;
    private float timer = 0;
    private float RateOfChange = 1;
    public GameObject Deathimg;
    void Start()
    {
        Vulture.velocity = Vector2.down * VultureVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > RateOfChange)
        {
            float velocity;
            float random = Random.Range(0f,2f);
            if (random < 1)
            {
                velocity = Random.Range(-Camera.main.orthographicSize * 2 - transform.position.x, Camera.main.orthographicSize * 2 - transform.position.x);
                Vulture.velocity = Vector2.right * ((Mathf.Abs(velocity) < Mathf.Abs(VultureVelocity)) ? velocity : VultureVelocity * Mathf.Sign(velocity));
            }
            else
            {
                velocity = Random.Range(- transform.position.y, Camera.main.orthographicSize - 5 - transform.position.y);
                Vulture.velocity = Vector2.up * ((Mathf.Abs(velocity) < VultureVelocity) ? velocity : VultureVelocity * Mathf.Sign(velocity));
            }
            timer = 0;
        }
        else
            timer += Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D colision)
	{
        FindObjectOfType<game_score>().add_score(200);
		Death();
	}

	private void Death()
	{
		Instantiate(Deathimg, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
