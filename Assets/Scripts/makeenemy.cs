using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeenemy : MonoBehaviour {
	
	private int enemynumber;
	private float timecounter = 0f;
	private float maketime = 2f;
	private float enemyspeed = -100f;
	public bool isgameactive = true;
	public Transform gpoint1, gpoint2, gpoint3;
	public float ghost_y_spawn1, ghost_y_spawn2, ghost_y_spawn3;
	public GameObject enemy;
	score score;

	void Start () {

		score = GameObject.Find ("Harry").GetComponent<score> ();
		ghost_y_spawn1 = gpoint1.position.y;
		ghost_y_spawn2 = gpoint2.position.y;
		ghost_y_spawn3 = gpoint3.position.y;

	}
	
	
	void Update () {

		if (score.point >= 500)
			maketime = 1f;
		if (score.point >= 1000) {
			maketime = 0.75f;
			enemyspeed = -135f;
		}
		if (score.point >= 2500) {
			maketime = 0.5f;
		}
		if (score.point >= 3500) {
			maketime = 0.33f;
			enemyspeed = -175f;
		}
		if (score.point >= 4000) {
			maketime = 0.25f;
			enemyspeed = -200f;
		}
	
	
		if (isgameactive == true)
		{
			for (int i = 0; i < 10000; i++) 
			{
				enemynumber = Random.Range (1, 4);
			}
			timecounter -= Time.deltaTime;
			if (timecounter < 0) 
			{
				if (enemynumber == 1) {
					TryMethod(-2.3f, ghost_y_spawn1);
				}
				if (enemynumber == 2) {
					TryMethod(0.12f, ghost_y_spawn2);
				}
				if (enemynumber == 3) {				
					TryMethod(2.3f, ghost_y_spawn3);
				}

				timecounter = maketime;
			}
		}

	}

	private void TryMethod(float spawn_x_position , float spawn_y_position)
    {
		GameObject go = Instantiate(enemy, new Vector3(spawn_x_position, spawn_y_position, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
		go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, enemyspeed, 0));
	}
}
