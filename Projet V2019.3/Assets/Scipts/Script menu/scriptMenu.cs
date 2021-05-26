using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptMenu : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetScene(string sceneName)
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
