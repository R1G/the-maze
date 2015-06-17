using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour 
{

	void OnTriggerEnter (Collider other)
	{
		Application.LoadLevel (2);
	}


}
