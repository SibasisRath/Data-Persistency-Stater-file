using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.IO;

public class MainSceneUIHandlerScript : MonoBehaviour
{
    public Text ScoreText;
    public Text theBestScore;
    public Text PlayerName;


    string json;

    // Start is called before the first frame update
    void Start()
    {
        PlayerName.text = "Name: " +GameObject.Find("PlayerClass").GetComponent<PlayerClass>().PlayerName;
        theBestScore.text = $"Best Score: {Load().playerName} : {Load().playerScore}";
    }

    // Update is called once per frame
    void Update()
    {
        DisplayScore();
    }

    private void DisplayScore()
    {
        ScoreText.text = $"Score : {GameObject.Find("MainManager").GetComponent<MainManager>().Points}";
    }

    private static SavePlayerData Load()
    {
        if (File.Exists(Application.dataPath + "/savePlayerData.txt"))
        {
            string json = File.ReadAllText(Application.dataPath + "/savePlayerData.txt");
            SavePlayerData savePlayerData = JsonUtility.FromJson<SavePlayerData>(json);
            return savePlayerData;
        }
        else
        {
            Debug.LogWarning("No Saved Files");
            return new SavePlayerData { playerName = "", playerScore = 0 };
        }
    }
    [Serializable]
    public class SavePlayerData
    {
        public string playerName;
        public int playerScore;
    }
}
