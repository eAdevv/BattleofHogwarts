using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour {
	public AudioClip magicVoice , deadVoice , ghostVoice;
	public Transform magicpos;
	public GameObject magic;
	public float speed = 7f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.D)) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.Translate (Vector2.left * speed * Time.deltaTime );
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector2.up * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector2.down * speed * Time.deltaTime);
		}
			
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			GameObject createmagic = Instantiate (magic, magicpos.position, magicpos.rotation) as GameObject;
			createmagic.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,10f);
			GetComponent<AudioSource> ().PlayOneShot (magicVoice, 0.5f);
		}
	}
}
