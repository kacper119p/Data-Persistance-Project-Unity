using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameTopText : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
       Text text = gameObject.GetComponent<Text>();
       text.text = "Best Score: " + NameScoreManager.Instance.highscore + " Name: " + NameScoreManager.Instance.name;
    }
}
