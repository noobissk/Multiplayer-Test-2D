using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Photon.Pun;

public class Menu : MonoBehaviourPunCallbacks
{

    public TMP_InputField inputField;


    public void HostButton()
    {
        PhotonNetwork.CreateRoom(inputField.text);
        Debug.Log("Creating");
    }

    public void JoinButton()
    {
        PhotonNetwork.JoinRoom(inputField.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("SampleScene");
    }
}
