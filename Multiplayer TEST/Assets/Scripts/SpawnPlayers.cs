using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject PlayerPrefab;

    [SerializeField] Vector2 SpawnPosition;
    private void Start()
    {
        PhotonNetwork.Instantiate(PlayerPrefab.name, SpawnPosition, Quaternion.identity);
    }
}
