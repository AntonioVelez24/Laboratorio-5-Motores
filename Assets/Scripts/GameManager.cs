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

    private bool activeAudioPanel = false;
    private bool activeExitPanel = false;

    private void Start()
    {
        menuCamera.Priority = 100;
        startCamera.Priority = 0;
        virtualCamera1.Priority = 0;
        virtualCamera2.Priority = 0;
        audioPanel.SetActive(false);
        exitPanel.SetActive(false);
    }
    public void SetAudioPanel()
    {
        if (activeAudioPanel == false)
        {
            activeAudioPanel = true;
            audioPanel.SetActive(true);
            menuCamera.Priority = 0;
            virtualCamera1.Priority = 100;
        }
        else
        {
            activeAudioPanel = false;
            audioPanel.SetActive(false);
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
            menuCamera.Priority = 0;
            virtualCamera2.Priority = 100;
        }
        else
        {
            activeExitPanel = false;
            exitPanel.SetActive(false);
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
