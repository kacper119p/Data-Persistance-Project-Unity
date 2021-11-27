using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NameScoreManager : MonoBehaviour
{
    public static NameScoreManager Instance;
    public string Playername;
    public int highscore;

    void Awake()
    {
        if(Instance != null)
        {
            Instance = this;
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadScore();
    }
    [System.Serializable]
    class HighScore
    {
        public int highscore;
    }

    public void SaveScore( int newScore)
    {
        if (highscore < newScore)
        {
            highscore = newScore;
            HighScore score = new HighScore();
            score.highscore = highscore;

            string json = JsonUtility.ToJson(score);
            File.WriteAllText(Application.persistentDataPath + "/BestScore.json", json);
        }
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/BestScore.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            HighScore score = JsonUtility.FromJson<HighScore>(json);

            highscore = score.highscore;
        }
        else
        {
            highscore = 0;
        }
    }
}
