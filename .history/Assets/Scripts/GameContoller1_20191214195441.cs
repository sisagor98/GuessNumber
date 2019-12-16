using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System;

public class GameContoller1 : MonoBehaviour
{
    private int num;
    private int guessNumber;
    private int countGuess;

    [SerializeField]
    private Text text;
    [SerializeField]
    private InputField input;

   // public InputField input;
    private void Awake() {
        num = Random.Range(0, 100);
        text.text = "Guess A Number Between 0 to 100";
    }
   public void GetInput(string guess){
       Debug.Log ("You Entered" + guess);
      // CompareGuess(guess);
      CompareGuess(Convert.ToInt32(guess));
       //CompareGuess(int.TryParse(guess));
       //CompareGuess(int.Parse(guess));
      // CompareGuess(System.Convert.ToInt32(guess));
       input.text = "";

   }

   void CompareGuess(int guess){
       
      // guess = Convert.ToInt32(guessvalu);
       if(guess  == num){
           text.text = "You Gyessed Correctly The Number Was" + guess;
       }
       else if(guess < num){
           text.text ="Your Guess Number is Less Then The Number You Trying Again To Guess";
       }
       else if(guess > num){
           text.text ="Your Guess Number is Greather Then The Number You Trying Again To Guess";
        }
   }
}

