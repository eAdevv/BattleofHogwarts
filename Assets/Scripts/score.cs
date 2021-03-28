using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {

	public UnityEngine.UI.Text scoretext,highscore;
	public int point = 0;


	void Start () {
		highscore.text = "High Score : " + PlayerPrefs.GetInt ("HighScore", 0).ToString();
	}
		

	void Update () {
		if (PlayerPrefs.GetInt ("HighScore") < point) {
			PlayerPrefs.SetInt ("HighScore", point);
			highscore.text = "High Score : " + point + "";
		}
	}


	public void Score () {
		scoretext.text = "SCORE : " + point + ""; 
	}
}


