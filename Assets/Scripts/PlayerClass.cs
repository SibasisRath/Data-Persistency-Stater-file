using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour, ISaveable
{
    private string playerName;
    private int playerScore;

    public string PlayerName { get => playerName; set => playerName = value; }
    public int PlayerScore { get => playerScore; set => playerScore = value; }

    public static PlayerClass Instance;
    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetPlayerName(string playerName)
    {
        PlayerName = playerName;
    }

    public string GetPlayerName()
    {
        return PlayerName;
    }

    public void SetPlayerScore(int playerScore)
    {
        PlayerScore = playerScore;
    }

    public int GetPlayerScore()
    {
        return PlayerScore;
    }
}
