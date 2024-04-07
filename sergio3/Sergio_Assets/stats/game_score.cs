using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class game_score : MonoBehaviour
{
	public Text score_text;
	public int score = 0;
	private float time = 0;
	// Start is called before the first frame update
	void Start()
	{
		score_text.text = "Score:" + score.ToString();
	}

	// Update is called once per frame
	void Update()
	{
		time += Time.deltaTime;
		if (time > 1)
		{
			time = 0;
			add_score(50);
		}
		
	}

	
	public void add_score(int value)
	{
		score += value;
		score_text.text = "Score:" + score.ToString();
	}

}
