using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

	public CharacterController Player;

	void start() 
	{
		Player = Player.GetComponent<CharacterController> ();
	}

	public  void ControllerColliderHit () 
	{
		Application.LoadLevel (2);
	}


}
