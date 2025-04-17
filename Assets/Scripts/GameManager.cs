using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CinemachineVirtualCamera menuCamera;
    public CinemachineVirtualCamera startCamera;
    public CinemachineVirtualCamera virtualCamera1;
    public CinemachineVirtualCamera virtualCamera2;
    public GameObject audioPanel;
    public GameObject exitPanel;
    public GameObject mainMenu;
    private bool activeAudioPanel = false;
    private bool activeExitPanel = false;
    private bool startingGame = false;
    public GameObject startText;

    void Update()
    {
        if (startingGame == false)
        {
            if (Input.anyKey)
            {
                startText.SetActive(false);
                mainMenu.SetActive(true);
                startingGame = true;
                startCamera.Priority = 0;
                menuCamera.Priority = 100;
            }
        }
    }
    public void SetAudioPanel()
    {
        if (activeAudioPanel == false)
        {
            activeAudioPanel = true;
            audioPanel.SetActive(true);
            mainMenu.SetActive(false);
            menuCamera.Priority = 0;
            virtualCamera1.Priority = 100;
        }
        else
        {
            activeAudioPanel = false;
            audioPanel.SetActive(false);
            mainMenu.SetActive(true);
            menuCamera.Priority = 100;
            virtualCamera1.Priority = 0;
        }
    }
    public void SetExitPanel()
    {
        if (activeExitPanel == false)
        {
            activeExitPanel = true;
            exitPanel.SetActive(true);
            mainMenu.SetActive(false);
            menuCamera.Priority = 0;
            virtualCamera2.Priority = 100;
        }
        else
        {
            activeExitPanel = false;
            exitPanel.SetActive(false);
            mainMenu.SetActive(true);
            menuCamera.Priority = 100;
            virtualCamera2.Priority = 0;
        }
    }
    public void ExitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
