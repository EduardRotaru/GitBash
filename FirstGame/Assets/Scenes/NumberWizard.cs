using System;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int _max;
    int _min;
    int _guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        _max = 1000;
        _min = 1;
        _guess = 500;

        Debug.Log("Welcome");
        Debug.Log("Pick a number");
        Debug.Log($"Highest number is: {_max}");
        Debug.Log($"Lowest number is: {_min}");
        Debug.Log($"Tell if number lower of hiher than {_guess}");
        Debug.Log("Push UP = Higher, Push DOWN = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                _min = _guess;
                NextGuess();
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                _max = _guess;
                NextGuess();
            }
            else if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("Game Ended");
                StartGame();
            }
        }
    }

    void NextGuess()
    {
        _guess = (int)Math.Ceiling((_max + _min) / 2f);
        Debug.Log($"Is it higher or lower than: {_guess}");
    }
}
