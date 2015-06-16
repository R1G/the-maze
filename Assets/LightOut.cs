using UnityEngine;
using System.Collections;

public class LightOut : MonoBehaviour {

	public float Battery;
	private Light Torch;

	void Start () {
		Battery = 100f;
		gameObject.SetActive (true);
		Torch = GetComponent<Light> ();
	}

	void Update () {

		if (Battery > 0f) {
			Battery -= .05f;
		}

		else if(Battery <= 0) {
			gameObject.SetActive (false);
		}

		Torch.intensity = 4f * Battery / 100;

	}
}



