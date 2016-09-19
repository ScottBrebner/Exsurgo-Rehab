using UnityEngine;
using System.Collections;

public class Active_Cycler : MonoBehaviour {

	public GameObject[] goArray;

	public void CycleTo(int n){
		for (int i = 0; i < goArray.Length; i++) {
			if (i == n)
				goArray [i].SetActive (true);
			else
				goArray [i].SetActive (false);
		}
	}

	public void HideAll(){
		foreach (GameObject g in goArray) {
			g.SetActive (false);
		}
	}
}
