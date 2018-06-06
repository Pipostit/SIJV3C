using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {
	
	public GameObject player;
	
	public float treshold;
	private Renderer rend;
	private float distance;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
		distance = Vector3.Distance(player.transform.position, transform.position);
        
		if(distance < treshold){
			rend.material.shader = Shader.Find("_Color");
			rend.material.SetColor("_Color",new Color(1,1,0,1));
		}
	}
}
