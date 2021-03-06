﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{

    [SerializeField]
    AudioSource newGameMusic;
    [SerializeField]
    AudioSource levelMusic;

    [SerializeField]
    GameObject pausePanel;


    public AudioMixerGroup mixer;



    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(8);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(5);
    }


    public void LoadLevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void Settings()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void GoBack()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeEffectVolume(float volume)
    {
        mixer.audioMixer.SetFloat("EffectVolume", Mathf.Lerp(-80, -20, volume));
    }

    public void ChangeMusicVolume(float volume)
    {
        mixer.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(-80, -20, volume));
    }
    public void GamePause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }
}
