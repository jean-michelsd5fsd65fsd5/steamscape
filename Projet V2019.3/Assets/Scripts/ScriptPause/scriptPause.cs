﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPause : MonoBehaviour
{
    public bool IsPaused = true;

    public GameObject MenuPause;
    public GameObject Perso;

    public GameObject MainCamera;
    public GameObject UICamera;

    void Start()
    {
        MainCamera.SetActive(true);
        UICamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    private void PauseGame()
    {
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
        MainCamera.SetActive(true);
        UICamera.SetActive(false);

        Perso.SetActive(true);
        MenuPause.SetActive(false);
        Time.timeScale = 1;
        IsPaused = false;
    }
}
