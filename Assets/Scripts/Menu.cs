using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {

	score score;


	public void PlayGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
		
	public void PlayAgin(){
		
		SceneManager.LoadScene ("Scane");
	}

	public void QuitGame(){
		Application.Quit();
	}


}
