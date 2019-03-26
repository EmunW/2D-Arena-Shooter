using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiFire : MonoBehaviour {

	public float fireRate;
	private float nextFire;
	public Transform[] bulletSpawn;
	public GameObject enemyBullet;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextFire){
			nextFire = Time.time + fireRate;
			Instantiate(enemyBullet, bulletSpawn[0].position, bulletSpawn[0].rotation);
			Instantiate(enemyBullet, bulletSpawn[1].position, bulletSpawn[1].rotation);
			Instantiate(enemyBullet, bulletSpawn[2].position, bulletSpawn[2].rotation);
			Instantiate(enemyBullet, bulletSpawn[3].position, bulletSpawn[3].rotation);
		}
	}
}
