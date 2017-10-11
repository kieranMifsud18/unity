using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;
    
    void NextGuess()
    {
         print("Is the number greater or smaller than " + guess + " ?");
            print("UP: Greater DOWN: Smaller ENTER: Equal");
    }
    // Use this for initialization
    void StartGame()
    {
        print("welcome to numberwuzard");
        Debug.Log("please choose a number between " + min+ "and " + max);
        NextGuess();
    }
    void Start()
    {
        StartGame();
    }
         
        

    // Update is called once per frame
    void Update()
        
    {   
       
        //if the input from the keyboard is DOWN Arrow
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UP Arrow pressed");
            min = guess;
            guess = (min + max) / 2;
            NextGuess();
        }

        else

        //if the input from the keyboard is DOWN Arrow
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DOWN Arrow pressed");
            max = guess;
            guess = (min + max) / 2;
            print("Is the number greater or smaller than " + guess + " ?");
            print("UP: Greater DOWN: Smaller ENTER: Equal");

        }

        else
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("ENTER Is pressed");
            print("Enter pressed");
            print("the number is " + guess);
        }
    }
}
