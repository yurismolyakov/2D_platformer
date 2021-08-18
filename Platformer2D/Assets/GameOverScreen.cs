﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private AudioSource gameOverSound;

    private void Start(){
        gameOverSound.Play();
    }

    public void RestartHandler(){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void ExitHandler(){
        SceneManager.LoadScene(0);
    }
}
