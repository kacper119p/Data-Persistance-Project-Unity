using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public TMP_InputField nameField;

    public void StartGame()
    {
        NameScoreManager.Instance.name = nameField.text;
        SceneManager.LoadScene(1);
    }

}
