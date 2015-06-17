using UnityEngine;
using System.Collections;

public class enemyAi : MonoBehaviour {


	private float Distance;
	private Transform target;
	private int moveSpeed = 5;
	private int rotationSpeed = 3;
	private Transform myTransform;
	
	public void Awake() {
		myTransform = transform;
	}

	public void Start () {
	
		target = GameObject.FindWithTag("Player").transform;
	}

	void Update () {
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

		Distance = Vector3.Distance (transform.position, target.position);
		if (Distance < 5) 
		{
			Application.LoadLevel(3);
		}
	}
}

