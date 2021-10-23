using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class NetworkPlayer : MonoBehaviourPunCallbacks
{
    public GameObject localCam;

    // Start is called before the first frame update
    void Start()
    {
        if(!photonView.IsMine){
            localCam.SetActive(false);

            MonoBehaviourPunCallbacks[] scripts = GetComponents<MonoBehaviourPunCallbacks>();

            for(int i=0; i<scripts.Length; i++){
                if(scripts[i] is NetworkPlayer) continue;
                else if(scripts[i] is PhotonView) continue;

                scripts[i].enabled = false;
            }
        }
        
    }


}
