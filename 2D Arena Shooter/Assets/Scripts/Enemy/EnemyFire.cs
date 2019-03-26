using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {
	public float fireRate;
	private float nextFire;
	public Transform bulletSpawn;
	public GameObject enemyBullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextFire){
			nextFire = Time.time + fireRate;
			Instantiate(enemyBullet, bulletSpawn.position, bulletSpawn.rotation);
		}
	}
}
