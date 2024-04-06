using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TieFighterMotion : MonoBehaviour
{
    public Rigidbody2D TieFighter;
    public Camera Camera;
    private float TieVelocity = 10;
	public GameObject Deathimg;
    private bool start = true;
    // Start is called before the first frame update
    void Start()
    {
        TieFighter.velocity = Vector2.down * TieVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (start && transform.position.y < Camera.main.orthographicSize - 2)
        {
            start = false;
            TieFighter.velocity = Vector2.right * TieVelocity;
        }
        if (transform.position.x < -Camera.main.orthographicSize * 2 + 2)
            TieFighter.velocity = Vector2.right * TieVelocity; 
        if (transform.position.x > Camera.main.orthographicSize * 2 - 2)
            TieFighter.velocity = Vector2.left * TieVelocity;
    }

	private void OnCollisionEnter2D(Collision2D colision)
	{
		Death();
	}

	private void Death()
	{
		Instantiate(Deathimg, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
