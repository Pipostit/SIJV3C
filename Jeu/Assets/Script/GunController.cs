using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
	
	public GameObject emitter;
	public GameObject bullet;
	public float speed;
	public float lifeTime;
	public float fireRate;
	private float nextFire = 0;

	void Update () {
		if(Input.GetAxis("Fire1") >0 && Time.time >= nextFire){
			nextFire = Time.time + fireRate;
			GameObject Temp_Bullet_Handler;
			
			Temp_Bullet_Handler = Instantiate(bullet,emitter.transform.position,emitter.transform.rotation) as  GameObject;
			//Temp_Bullet_Handler.transform.Rotate(Vector3.left*90);
			
			Rigidbody TempRB;
			TempRB = Temp_Bullet_Handler.GetComponent<Rigidbody>();
			
			TempRB.velocity = transform.TransformDirection(new Vector3(0,0,speed));
			
			Destroy(Temp_Bullet_Handler, 10.0f);
	};
}
}