using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VelNet;
public class NetworkGameManager : MonoBehaviour
{
    //[SerializeField] NetworkObject testNO;
    // Start is called before the first frame update
    [SerializeField] VRPlayer myPlayer;
    void Start()
    {
        VelNetManager.OnLoggedIn += () => {
            VelNetManager.Join("group2FinalProject");//"myroom2"
        };
        VelNetManager.OnJoinedRoom += (roomname) => {
            NetworkObject player = VelNetManager.NetworkInstantiate("Player");
            player.GetComponent<VelNetPlayer>().myPlayer = myPlayer;
        };
    }

    // Update is called once per frame
    void Update()
    {
		
    }
}
