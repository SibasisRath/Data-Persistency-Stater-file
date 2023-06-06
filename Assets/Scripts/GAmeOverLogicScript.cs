using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GAmeOverLogicScript : MonoBehaviour
{
    private SavePlayerData savePlayerData;
    private bool isHighestScore;
    private PlayerClass playerGameObject;
    private ISaveable saveable;

    public bool IsHighestScore { get => isHighestScore; set => isHighestScore = value; }

    private void Awake()
    {
        playerGameObject = GameObject.Find("PlayerClass").GetComponent<PlayerClass>();
        saveable = playerGameObject.GetComponent<ISaveable>();
        isHighestScore = false;
        savePlayerData = Load();
        Compare(ref savePlayerData, ref playerGameObject);
    }
    private void Compare(ref SavePlayerData savePlayerData, ref PlayerClass playerGameObject)
    {
        if (savePlayerData.playerScore > saveable.GetPlayerScore())
        {
            IsHighestScore = false;
        }
        else
        {
            IsHighestScore = true;
            save();
        }
    }

    public PlayerClass ReturnPlayerClass()
    {
        return playerGameObject;
    } 
    public SavePlayerData ReturnBestPlayerData()
    {
        return savePlayerData;
    }

    private void save()
    {
        savePlayerData = new SavePlayerData
        {
            playerName = saveable.GetPlayerName(),
            playerScore = saveable.GetPlayerScore()
        };

        string json = JsonUtility.ToJson(savePlayerData);
        File.WriteAllText(Application.dataPath + "/savePlayerData.txt", json);
    }
    private SavePlayerData Load()
    {
        if (File.Exists(Application.dataPath + "/savePlayerData.txt"))
        {
            string json = File.ReadAllText(Application.dataPath + "/savePlayerData.txt");
            return JsonUtility.FromJson<SavePlayerData>(json);
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
