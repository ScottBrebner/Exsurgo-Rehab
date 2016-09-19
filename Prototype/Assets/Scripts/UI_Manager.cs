using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI_Manager : MonoBehaviour {

	public bool bluetoothConnected = false; // to be replaced by proper stuff
	public GameObject[] leftHandExclusive, rightHandExclusive;
	public GameObject stopPanel;
	public Text connectionStatus;
	public Toggle speedNormal, speedSlow;

	void Awake () {
		// check for bluetooth connectivity
		if (bluetoothConnected)
			DisplayConnected ();
		else
			DisplayDisconnected ();
	}

	void Start () {
	}

	void DisplayConnected(){
		connectionStatus.text = "Connected";
		connectionStatus.color = new Color (0f, 0.58f, 0.27f);
	}

	void DisplayDisconnected(){
		connectionStatus.text = "Disconnected";
		connectionStatus.color = new Color (1f, 0f, 0f);
	}

	public void ShowStop(){
		stopPanel.SetActive (true);
	}

	public void StopExercise(){
		// yell at the bluetooth controller to stop what it's doing
		print("Bluetooth, you stop it and you stop it right now!");
		stopPanel.SetActive (false);
	}

	public void UpdateSpeed(){
		if (speedNormal.isOn)
			print ("Speed wants to be normal.");
		else if (speedSlow.isOn)
			print ("Speed wants to be slow.");
	}

	public void DisableLeftHand(){
		foreach (GameObject b in leftHandExclusive) {
			if(b.GetComponent<Button>() != null)
				b.GetComponent<Button>().interactable = false;
		}
		foreach (GameObject b in rightHandExclusive) {
			if(b.GetComponent<Button>() != null)
				b.GetComponent<Button>().interactable = true;
		}
	}

	public void DisableRightHand(){
		foreach (GameObject b in leftHandExclusive) {
			if(b.GetComponent<Button>() != null)
				b.GetComponent<Button>().interactable = true;
		}
		foreach (GameObject b in rightHandExclusive) {
			if(b.GetComponent<Button>() != null)
				b.GetComponent<Button>().interactable = false;
		}
	}
}