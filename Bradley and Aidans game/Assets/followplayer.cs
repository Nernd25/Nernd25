using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class followplayer : MonoBehaviour {

	public Transform playerTransform;
	public Vector3 playerVector3;

	public NavMeshAgent agent;

	void Start(){
	
		agent.autoBraking = false;
	
	}

	void Update(){
	
		playerVector3 = playerTransform.transform.position;


		agent.destination = playerVector3;

	
	}

}
