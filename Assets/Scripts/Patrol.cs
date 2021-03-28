using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

	public float speed;
	public float startWaitTime;
	private float waitTime;
	public Transform moveSpot;
	public float maxX , maxY, minX , minY;
	makeenemy makeenemy;


	void Start () {
		waitTime = startWaitTime;
		moveSpot.position = new Vector2 (Random.Range (minX, maxX), Random.Range (minY, maxY));
		makeenemy = GameObject.Find("ScriptEnemy").GetComponent<makeenemy> ();
	}
	

	void Update () {

		transform.position = Vector2.MoveTowards (transform.position, moveSpot.position, speed * Time.deltaTime);

		if (Vector2.Distance (transform.position, moveSpot.position) < 0.2f) {
			if (waitTime <= 0) {
				waitTime = startWaitTime;
			} else {
				waitTime -= Time.deltaTime;
			}
		}

		if (makeenemy.isgameactive == false) {
			GameObject[] go = GameObject.FindGameObjectsWithTag ("enemy");
			for (int i = 0; i < go.Length; i++) {
				Destroy (this.gameObject);
			}
		}
		
	}
}
