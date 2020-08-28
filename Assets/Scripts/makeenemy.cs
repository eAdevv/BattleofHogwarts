using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeenemy : MonoBehaviour {

	private int enemynumber;
	private float timecounter = 0f;
	private float maketime = 3f;
	private float enemyspeed = -100f;
	public bool isgameactive = true;
	public Transform gpoint1, gpoint2, gpoint3;
	public float gspawn1, gspawn2, gspawn3;
	public GameObject enemy;
	score score;


	void Start () {
		score = GameObject.Find ("Harry").GetComponent<score> ();
		gspawn1 = gpoint1.position.y;
		gspawn2 = gpoint2.position.y;
		gspawn3 = gpoint3.position.y;
	}
	
	// Update is called once per frame
	void Update () {

		if (score.point >= 500)
			maketime = 2f;
		if (score.point >= 1000) {
			maketime = 1.5f;
			enemyspeed = -125f;
		}
		if (score.point >= 1500) {
			maketime = 1f;
			enemyspeed = -150f;
		}
		if (score.point >= 3000) {
			maketime = 0.75f;
			enemyspeed = -175f;
		}
		if (score.point >= 6000) {
			maketime = 0.5f;
			enemyspeed = -200f;
		}
		if (score.point >= 10000)
			maketime = 0.40f;

		
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
					GameObject go =	Instantiate (enemy, new Vector3 (-2.3f, gspawn1, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
					go.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0, enemyspeed, 0));
				}
				if (enemynumber == 2) {
					GameObject go = Instantiate (enemy, new Vector3 (0.12f, gspawn2, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
					go.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0, enemyspeed, 0));
				}
				if (enemynumber == 3) {
					GameObject go = Instantiate (enemy, new Vector3 (2.3f, gspawn3, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
					go.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0, enemyspeed, 0));
				}
				timecounter = maketime;
			}
		}

	}
}
