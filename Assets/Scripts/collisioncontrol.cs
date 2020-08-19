using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisioncontrol : MonoBehaviour
{
	public GameObject magic;
	makewall makewall;
	makeenemy makeenemy;


	void Start () {
		makewall = GameObject.Find ("ScriptWall").GetComponent<makewall> ();
		makeenemy = GameObject.Find("ScriptEnemy").GetComponent<makeenemy> ();
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
					Destroy (collision.gameObject);
					makewall.isgameactive = false;
					makeenemy.isgameactive = false;
				}
			}
	}



}

