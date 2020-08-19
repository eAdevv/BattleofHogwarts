using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makewall : MonoBehaviour {

	private int wallnumber;
	private float timecounter = 0f;
	private float wallingtime = 2.5f;
	private float wallspeed = -100f;
	public bool isgameactive = true;

	public GameObject wall;
	score score;
	void Start () {
		score = GameObject.Find("oyuncu").GetComponent<score> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (score.point >= 500)
			wallingtime = 2f;
		if (score.point >= 1000) {
			wallingtime = 1f;
			wallspeed = -125f;
		}
		if (score.point >= 2000) {
			wallingtime = 0.80f;
			wallspeed = -150f;
		}
		if (score.point >= 3000) {
			wallingtime = 0.60f;
			wallspeed = -175f;
		}
		if (score.point >= 6000) {
			wallingtime = 0.50f;
			wallspeed = -200f;
		}
		if (score.point >= 10000){
			wallingtime = 0.45f;
			wallspeed = -300f;
		}



		if (isgameactive == true) 
		{
			for (int i = 0; i < 10000; i++) {
				wallnumber = Random.Range (1, 4);
			}

			timecounter -= Time.deltaTime;

			if (timecounter < 0) 
			{
				if (wallnumber == 1) {
					GameObject go =	Instantiate (wall, new Vector3 (-2.3f, 17f, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
					go.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0, wallspeed, 0));
				}
				if (wallnumber == 2) {
					GameObject go = Instantiate (wall, new Vector3 (0.12f, 17f, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
					go.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0, wallspeed, 0));
				}
				if (wallnumber == 3) {
					GameObject go = Instantiate (wall, new Vector3 (2.3f, 17f, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
					go.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0, wallspeed, 0));
				}
				timecounter = wallingtime;
			}
		} 
		else 
		{
			GameObject[] go = GameObject.FindGameObjectsWithTag ("wall");
			for (int i = 0; i < go.Length; i++) {
				go [i].GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			}
		}
			
			
	}
}
