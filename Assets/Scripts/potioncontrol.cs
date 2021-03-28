using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potioncontrol : MonoBehaviour {

	public int Effect;
	makepotion makepotion;
	score score;
	controls  controls;
	void Start () {
		makepotion = GameObject.Find ("ScriptPotion").GetComponent<makepotion> ();	
		score = GameObject.Find ("Harry").GetComponent<score> ();
		controls = GameObject.Find ("Harry").GetComponent<controls> ();
	}

	
		
	void OnTriggerEnter2D(Collider2D collider)
	{
		
		if (collider.gameObject.tag == "Player") 
		{
			makepotion.PotionActive = false;
			controls.gameObject.GetComponent<AudioSource> ().PlayOneShot (controls.bookSound, 1f);
			Destroy (this.gameObject);

			GameObject[] Ghosts = GameObject.FindGameObjectsWithTag ("enemy");
			for (int i = 0; i < Ghosts.Length; i++)
			{
				Destroy (Ghosts [i]);

				score.point += 100;
			}
			
		} 
	}


}
