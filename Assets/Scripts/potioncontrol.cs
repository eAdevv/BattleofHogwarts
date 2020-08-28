using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potioncontrol : MonoBehaviour {

	public int Effect;
	makepotion makepotion;
	score score;
	void Start () {
		makepotion = GameObject.Find ("ScriptPotion").GetComponent<makepotion> ();	
		score = GameObject.Find ("Harry").GetComponent<score> ();
	}

	void Update () {
		
	}

		
	void OnTriggerEnter2D(Collider2D collider)
	{
		
		if (collider.gameObject.tag == "Player") 
		{
			makepotion.PotionActive = false;
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
