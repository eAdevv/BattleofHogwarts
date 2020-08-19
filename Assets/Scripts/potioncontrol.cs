using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potioncontrol : MonoBehaviour {

	public GameObject player;
	public float GreenPotionEffectTime , RedPotionEffectTime;
	makewall makewall;
	makeenemy makeenemy;
	controls control;
	void Start () {
		
		makewall = GameObject.Find ("ScriptWall").GetComponent<makewall> ();
		makeenemy = GameObject.Find("ScriptEnemy").GetComponent<makeenemy> ();
		control = GameObject.Find ("oyuncu").GetComponent<controls> ();
	}
	
	void OnTriggerEnter2D(Collider2D collider){

		if (collider.gameObject.tag.Equals("Player")) {

	}
}
}
