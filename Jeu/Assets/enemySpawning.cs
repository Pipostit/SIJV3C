using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class enemySpawning : MonoBehaviour {
	
	public Transform enemy;
	
	// Use this for initialization
	void Start () {
		Instantiate(enemy, new Vector3(0, 0, 0),  Quaternion.Euler(new Vector3(-90, 0, 0)));	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
