using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_maneger : MonoBehaviour
{
	public static int total_score = 0;

	public static void Add_Score(int score)
	{
		total_score += score;
	}
	
	public static void Reset_Score()
	{
		total_score = 0;
	}
}
