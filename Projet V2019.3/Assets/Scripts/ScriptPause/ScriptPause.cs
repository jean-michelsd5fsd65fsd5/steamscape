using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPause : MonoBehaviour
{

    public static bool IsPaused = false;
    public static bool isPanelNoteAffiché = false;

    public GameObject MenuPause;
    public GameObject Perso;

    public GameObject PanelNote;


    public GameObject MainCamera;
    public GameObject UICamera;

    public GameObject CurseurMilieu;

    void Start()
    {
        ResumeGame();
        MainCamera.SetActive(true);
        UICamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPanelNoteAffiché)
                DontShowPanelNote();
            else
            {
                if (IsPaused)
                    ResumeGame();
                else
                    PauseGame();
            }
        }
    }

    private void PauseGame()
    {
        CurseurMilieu.SetActive(false);

        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;

        Perso.SetActive(false);
        MenuPause.SetActive(true);

        MainCamera.SetActive(false);
        UICamera.SetActive(true);
        Time.timeScale = 0;
        IsPaused = true;
    }

    private void ResumeGame()
    {


        CurseurMilieu.SetActive(true);
        MainCamera.SetActive(true);
        UICamera.SetActive(false);

        Perso.SetActive(true);
        MenuPause.SetActive(false);

        Time.timeScale = 1;
        IsPaused = false;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    public void DontShowPanelNote()
    {
        PanelNote.SetActive(false);
        isPanelNoteAffiché = false;

        Transform[] notes = PanelNote.GetComponentsInChildren<Transform>();
        foreach (Transform note in notes)
        {
            if (note.name != "Echap")
                note.gameObject.SetActive(false);
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }
}