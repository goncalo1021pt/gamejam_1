using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TieFighterMotion : MonoBehaviour
{
    public Rigidbody2D TieFighter;
    private float TieVelocity = 10;
    public float down;
	public GameObject Deathimg;
    private bool start = true;
	public Sprite dark;
	public Sprite light;
	private int	side = 0;
    // Start is called before the first frame update
    void Start()
    {
		side = Side.sidef.choseSide(0);
		SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
		if (side == 1)
		{
			spriteRenderer.sprite = light;
		}
		else
		{
			spriteRenderer.sprite = dark;
		}
        down = Random.Range(5, 10);
        TieFighter.velocity = Vector2.down * TieVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (start && transform.position.y < Camera.main.orthographicSize - down)
        {
            start = false;
            TieFighter.velocity = Vector2.right * TieVelocity;
        }
        else if (transform.position.x < -Camera.main.orthographicSize * 2 + 2)
            TieFighter.velocity = Vector2.right * TieVelocity; 
        else if (transform.position.x > Camera.main.orthographicSize * 2 - 2)
            TieFighter.velocity = Vector2.left * TieVelocity;
    }

	private void OnCollisionEnter2D(Collision2D colision)
	{
        FindObjectOfType<game_score>().add_score(150);
		Death();
	}

	private void Death()
	{
		Instantiate(Deathimg, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
