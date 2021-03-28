using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class controls : MonoBehaviour
{
	public AudioClip magicVoice, deadVoice, ghostVoice, bookSound;
	public Transform magicpos;
	public GameObject magic;
	public float speed = 0.5f;
	private Rigidbody2D rb;
	private float directX, directY;
    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
		directX = CrossPlatformInputManager.GetAxis("Horizontal") * speed;
		directY = CrossPlatformInputManager.GetAxis("Vertical") * speed;
		rb.velocity = new Vector2(directX, directY);

		if (CrossPlatformInputManager.GetButtonDown("Fire"))
		{
			GameObject createmagic = Instantiate(magic, magicpos.position, magicpos.rotation) as GameObject;
			createmagic.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10f);
			GetComponent<AudioSource>().PlayOneShot(magicVoice, 0.5f);

		}
	}

    

}
