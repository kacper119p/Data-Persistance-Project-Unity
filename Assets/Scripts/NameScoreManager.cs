using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameScoreManager : MonoBehaviour
{
    public static NameScoreManager Instance;
    public string Playername;

    void Awake()
    {
        if(Instance != null)
        {
            Instance = this;
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

   
}
