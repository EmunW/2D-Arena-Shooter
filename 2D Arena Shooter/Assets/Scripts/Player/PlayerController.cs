using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Boundary the player can move
[System.Serializable]
public class Boundary{
	public float xMin, xMax, yMin, yMax;
}

public class PlayerController : MonoBehaviour {

	public Boundary boundary;

	public float speed;
	public float fireRate;

	private float nextFire;
	
	private Rigidbody2D rb;
	public GameObject bullet;
	public Transform bulletSpawn;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1") && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);
			SoundManagerScript.PlaySound("Laser");
		}
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector2 movement = new Vector2(moveHorizontal, moveVertical) * speed;
		rb.velocity = movement;

		// convert mouse position into world coordinates
		Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
 
 		// get direction you want to point at
 		Vector2 direction = (mouseScreenPosition - (Vector2) transform.position).normalized;
 
 		// set vector of transform directly
 		transform.up = direction;
		
		rb.position = new Vector3(Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
		Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax), 0.0f);
	}
}
