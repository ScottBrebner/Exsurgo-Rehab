using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Exercise_Prompt : MonoBehaviour {

	public InputField repetitions;
	public int exerciseNumber, exerciseReps;
	public string exerciseName;

	void Start(){
		repetitions.text = "3";
		UpdateExerciseRepetitions ();
	}

	public void StartExercise(){
		print ("Would begin exercise " + exerciseNumber + ": " + exerciseName + " " + exerciseReps + " times.");
	}

	public void UpdateExerciseRepetitions(){
		int number;
		bool result = int.TryParse(repetitions.text, out number);
		if (result) {
			if(number > 99){
				number = 99;
				repetitions.text = number.ToString();
				print ("Repetitions cannot be higher than 99!");
			}
			if(number < 1){
				number = 1;
				repetitions.text = number.ToString();
				print ("Repetitions cannot be lower than 1!");
			}
			exerciseReps = number;
		} 
		else {
			repetitions.text = "3";
			exerciseReps = 3;
			print ("Conversion error occured! Input an integer please.");
		}
	}
}
