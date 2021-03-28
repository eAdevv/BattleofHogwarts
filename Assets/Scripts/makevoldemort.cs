using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makevoldemort : MonoBehaviour {
	public UnityEngine.UI.Button playagain;
	private float timecounter = 0f;
	private float vtime = 2.5f;
	public float vspeed = -100f;
	public bool isgameactive = true;
	public Transform wpoint1, wpoint2, wpoint3;
	public float wspawn1, wspawn2, wspawn3;
	public GameObject voldemort;
	score score;
	void Start () {
		score = GameObject.Find("Harry").GetComponent<score> ();
		wspawn1 = wpoint1.position.y;
		wspawn2 = wpoint2.position.y;
		wspawn3 = wpoint3.position.y;
	}

	// Update is called once per frame
	void Update () {

		if (score.point >= 500)
			vtime = 2f;
		if (score.point >= 1000) {
			vtime = 1.5f;
			vspeed  = -125f;
		}
		if (score.point >= 2500) {
			vtime = 1.25f;
			vspeed = -175f;
		}
		if (score.point >= 3500) {
			vtime = 1f;
			vspeed  = -200f;
		}
		if (score.point >= 4000)
		{
			vtime = 0.5f;
			vspeed = -250f;
		}
		if (score.point >= 10000){
			vtime = 0.35f;
			vspeed  = -300f;
		}

		if (isgameactive == true) 
		{

			timecounter -= Time.deltaTime;

			if (timecounter < 0) 
			{

				GameObject go =	Instantiate (voldemort, new Vector3 (Random.Range(-2.8f,2.8f), wspawn1, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
				go.GetComponent<Rigidbody2D> ().AddForce (new Vector3 (0, vspeed, 0));


				timecounter = vtime;
			}
		} 
		else 
		{
			GameObject[] go = GameObject.FindGameObjectsWithTag ("wall");
			for (int i = 0; i < go.Length; i++) {
				go [i].GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
			}
			playagain.gameObject.SetActive (true);
		}


	}
}

