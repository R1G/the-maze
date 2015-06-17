using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

	public Button PlayAgain;
	public Button EndQuit;
	// Use this for initialization
	void Start () {
		PlayAgain = PlayAgain.GetComponent<Button> ();
		EndQuit = EndQuit.GetComponent<Button> ();
	}

	public void EndPlayPress () 
	{
		Application.LoadLevel (0);
	}

	public void FinalQuit ()
	{
		Application.Quit ();
	}
}
