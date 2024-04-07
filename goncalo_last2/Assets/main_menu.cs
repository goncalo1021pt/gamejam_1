using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{

	public void Start_Light_game()
	{
		SceneManager.LoadSceneAsync(1); 
	}
	
	public void Start_Dark_game()
	{
		SceneManager.LoadSceneAsync(2); 
	}
	public void Quit_Game()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
