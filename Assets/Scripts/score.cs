using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

	public UnityEngine.UI.Text scoretext;
	public int point = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoretext.text = "Score : " + point + "";
	}
}
