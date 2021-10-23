using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{
    public Transform spawnPoint;

    private GameObject spawnedPlayerPrefeb;

    public void OnClickStart(){
        spawnedPlayerPrefeb = PhotonNetwork.Instantiate("Player", spawnPoint.position, spawnPoint.rotation);
    }

}
