using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptMenu : MonoBehaviour
{
    public GameObject settingsWindow;


    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void CloseSettingWindow()
    {
        settingsWindow.SetActive(false);
    }

    public void SettingButton()
    {
        settingsWindow.SetActive(true);
    }


}
