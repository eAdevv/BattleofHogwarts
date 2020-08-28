using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostcontrol : MonoBehaviour {
	makevoldemort makevoldemort;
	makeenemy makeenemy;
	score score;
	public UnityEngine.UI.Text scoretext;
	public GameObject GhostAnim;
	controls  controls;

	void Start () {
		makevoldemort = GameObject.Find ("ScriptVoldemort").GetComponent<makevoldemort> ();
		makeenemy = GameObject.Find("ScriptEnemy").GetComponent<makeenemy> ();
		score = GameObject.Find ("Harry").GetComponent<score> ();
		controls = GameObject.Find ("Harry").GetComponent<controls> ();
	}

	void OnTriggerEnter2D(Collider2D collider){
			if (collider.gameObject.tag == "magic") {
				Destroy (this.gameObject);
				controls.gameObject.GetComponent<AudioSource> ().PlayOneShot (controls.ghostVoice, 1f);
				GameObject go = Instantiate (GhostAnim, transform.position, transform.rotation) as GameObject;
				Destroy (go,0.250f);
				Destroy (collider.gameObject);
				score.point += 100;
			}
			if (collider.gameObject.tag == "border") {
				Destroy (this.gameObject);
			}
			if (collider.gameObject.tag == "Player") {
				collider.gameObject.GetComponent<Animator> ().enabled = true;
				Destroy (collider.gameObject,4f);
				collider.gameObject.GetComponent<AudioSource> ().PlayOneShot (controls.deadVoice, 1f);
				makevoldemort.isgameactive = false;
				makeenemy.isgameactive = false;
			}
		} 
	
	}

