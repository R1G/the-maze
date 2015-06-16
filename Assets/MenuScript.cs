using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
	
	public Button PlayText;
	public Button ExitText;
	
	void start() 
	{
		PlayText = PlayText.GetComponent<Button> ();
		ExitText = ExitText.GetComponent<Button> ();
	}

	public void PlayPress()
	{
		Application.LoadLevel (1);
	}

	public void ExitPress()
	{
		Application.Quit ();
	}
}
