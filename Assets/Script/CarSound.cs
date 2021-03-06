using UnityEngine;
using System.Collections;

public class CarSound : MonoBehaviour {

	public float maxPitch = 1.8f;
	public float maxWheelRevolution = 800f;
	
	private CarController carController;
	
	void Start () {
		carController = GetComponent<CarController>();
	}
	
	void Update () {
		float pitch = 1f;
		if (carController.IsAccelOn()) {
			if (carController.IsWheelGrounded()) {
				pitch = carController.GetEngineRevolution() / maxWheelRevolution + 1f;
				if (pitch > maxPitch) {
					pitch = maxPitch;
				}
			} else {
				pitch = maxPitch;
			}
		}
		
		audio.pitch = pitch;
	}
}
