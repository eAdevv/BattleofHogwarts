using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makepotion : MonoBehaviour {

	public GameObject Potion;
	private float PotionTime = 2f;
	private float PotionSpawnTime = 5f;
	private float PotionRespawnTime;
	private bool PotionActive;
	makeenemy makeenemy;
	GameObject go ;
	void Start () {
		makeenemy =  GameObject.Find("ScriptEnemy").GetComponent<makeenemy> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (makeenemy.isgameactive == true) 
		{
			for (int i = 0; i < 10000; i++) 
			{
				PotionRespawnTime = Random.Range (7, 13);
			}

			PotionSpawnTime -=Time.deltaTime;
		
			if(PotionSpawnTime <= 0)
			{
				go = Instantiate (Potion, new Vector3 (0, 11f, 0), Quaternion.Euler (0, 0, 0));
				PotionActive = true;
					PotionSpawnTime = PotionRespawnTime;
			}

			if (PotionActive == true)
			{
				PotionTime -= Time.deltaTime;
				if (PotionTime <= 0) 
				{
					Destroy (go.gameObject);
					PotionTime = 2f;
					PotionActive = false;
				}
			}
		}
	}

}


