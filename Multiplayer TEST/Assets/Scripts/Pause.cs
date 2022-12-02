using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class Pause : MonoBehaviour
{
    public static bool IsPaused;
    [SerializeField] GameObject PauseMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !IsPaused)
        {
            IsPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && IsPaused)
        {
            IsPaused = false;
        }


        if (IsPaused)
        {
            PauseMenu.SetActive(true);
        }
        else
        {
            PauseMenu.SetActive(false);
        }
    }

    public void QUITGAME()
    {
        PhotonNetwork.LeaveRoom();
        Application.Quit();
    }
    public void ToMenu()
    {
        PhotonNetwork.LeaveRoom();
        SceneManager.LoadScene("Menu");
    }

}
