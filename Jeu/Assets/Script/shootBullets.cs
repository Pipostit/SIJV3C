using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBullets : MonoBehaviour {
	
	public GameObject bullet;

	public GameObject player;
	public GameObject emitter;
	public float speed;
	public float lifeTime;
	public float fireRate;
	private float nextFire = 0;
	
	public float angle;
	private float tangSpeed;

void Start(){
	tangSpeed = Mathf.Tan(angle)*speed;
	
	}
	void Update () {
		
		transform.LookAt(player.transform.position);
		
		if(Time.time >= nextFire && Time.time >=10){
			nextFire = Time.time + fireRate;
			GameObject Temp_Bullet_Handler;
			Temp_Bullet_Handler = Instantiate(bullet,emitter.transform.position,emitter.transform.rotation) as  GameObject;
			
			Rigidbody TempRB;
			
			TempRB = Temp_Bullet_Handler.GetComponent<Rigidbody>();
			
			TempRB.velocity = transform.TransformDirection(new Vector3(Random.Range(-tangSpeed, tangSpeed),Random.Range(-tangSpeed, tangSpeed),speed));
			
			Destroy(Temp_Bullet_Handler, 10.0f);
	};
}
}