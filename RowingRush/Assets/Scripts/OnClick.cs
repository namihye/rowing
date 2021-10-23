using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{  
    public GameObject DisconnectPannel;
    public GameObject LobbyPannel;
    public GameObject RoomPannel;

    public void OnClick_disconnect(){
        DisconnectPannel.SetActive(false);
    }

    public void OnClick_Lobby(){
        LobbyPannel.SetActive(false);
    }
}
