using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisioncontrol : MonoBehaviour
{
	public GameObject magic;
	makevoldemort makevoldemort;
	makeenemy makeenemy;
	controls  controls;

	void Start () {
		makevoldemort = GameObject.Find ("ScriptVoldemort").GetComponent<makevoldemort> ();
		makeenemy = GameObject.Find("ScriptEnemy").GetComponent<makeenemy> ();
		controls = GameObject.Find ("Harry").GetComponent<controls> ();
	}



	void OnCollisionEnter2D (Collision2D collision)
	{


			if (this.gameObject.tag.Equals ("border")) 
			{
				if (collision.gameObject.tag.Equals ("magic"))
					Destroy (collision.gameObject);
				else if (collision.gameObject.tag.Equals ("wall"))
					Destroy (collision.gameObject);
			}

			if (this.gameObject.tag.Equals ("wall")) 
			{
				if (collision.gameObject.tag.Equals ("magic"))
					Destroy (collision.gameObject);
				else if (collision.gameObject.tag.Equals ("Player")) {
					collision.gameObject.GetComponent<Animator> ().enabled = true;
					Destroy (collision.gameObject, 4f);
					makevoldemort.isgameactive = false;
					makeenemy.isgameactive = false;
					collision.gameObject.GetComponent<AudioSource> ().PlayOneShot (controls.deadVoice, 1f);
				}
			}
	}



}

