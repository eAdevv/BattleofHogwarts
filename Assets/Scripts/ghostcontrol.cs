using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostcontrol : MonoBehaviour {
	makewall makewall;
	makeenemy makeenemy;
	score score;
	public UnityEngine.UI.Text scoretext;


	void Start () {
		makewall = GameObject.Find ("ScriptWall").GetComponent<makewall> ();
		makeenemy = GameObject.Find("ScriptEnemy").GetComponent<makeenemy> ();
		score = GameObject.Find ("oyuncu").GetComponent<score> ();

	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.gameObject.tag == "magic") {
			Destroy (this.gameObject);
			Destroy (collider.gameObject);
			score.point += 100;
		}
		 if (collider.gameObject.tag == "border") {
			Destroy (this.gameObject);
		}
		if (collider.gameObject.tag == "Player") {
			Destroy (collider.gameObject);
			makewall.isgameactive = false;
			makeenemy.isgameactive = false;

		}
	}
}
