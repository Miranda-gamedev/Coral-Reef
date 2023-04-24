using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    int LevelsUnlocked;

    public Button[] Buttons;


    // Start is called before the first frame update
    void Start()
    {
        LevelsUnlocked = PlayerPrefs.GetInt("LevelsUnlocked", 1);

        for (int i = 0; i < Buttons.Length; i++)
        {
            Buttons[i].interactable = false;
        }

        for (int i = 0; i < LevelsUnlocked; i++)
        {
            Buttons[i].interactable = true;
        }

    }

    public void LoadLevel(int LevelIndex)
    {
        SceneManager.LoadScene(LevelIndex);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
