using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxGuess;
    int minGuess;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maxGuess = 1000;
        minGuess = 1;
        guess = 500;

        Debug.Log("Welcome to number Wizard");
        Debug.Log("Pick a number");
        Debug.Log("Highest number: " + maxGuess);
        Debug.Log("Lowest number: " + minGuess);
        Debug.Log("Is your number Higher or Lower than " + guess + "?");
        Debug.Log("Push UP for higher, push DOWN for lower, ENTER for correct");
        maxGuess = maxGuess + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minGuess = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxGuess = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed.");
            StartGame();
        }
    }
    void NextGuess()
    {
            guess = (maxGuess + minGuess) / 2;
            Debug.Log("Is it higher or lower than " + guess + "?");
    }
}
