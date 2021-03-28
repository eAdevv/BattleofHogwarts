using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makepotion : MonoBehaviour {

	public GameObject Potion;
	private float PotionTime = 3f;
	private float PotionSpawnTime = 5f;
	private float PotionRespawnTime;
	public bool PotionActive;
	makeenemy makeenemy;
	score score;
	GameObject go ;
	void Start () {
		makeenemy =  GameObject.Find("ScriptEnemy").GetComponent<makeenemy> ();
		score = GameObject.Find ("Harry").GetComponent<score> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (makeenemy.isgameactive == true && score.point > 1000f ) 
		{
			for (int i = 0; i < 10000; i++) 
			{
				PotionRespawnTime = Random.Range (12,26);
			}

			PotionSpawnTime -=Time.deltaTime;
		
			if(PotionSpawnTime <= 0)
			{
				go = Instantiate (Potion, new Vector3 (Random.Range(-2.8f,2.8f), Random.Range(2f,10f), 0), Quaternion.Euler (0, 0, 0));
				PotionActive = true;
					PotionSpawnTime = PotionRespawnTime;
			}


			if (PotionActive == true)
			{
				PotionTime -= Time.deltaTime;
				if (PotionTime <= 0) 
				{
					Destroy (go.gameObject);
					PotionTime = 3f;
					PotionActive = false;
				}
			}
		}
	}


}


