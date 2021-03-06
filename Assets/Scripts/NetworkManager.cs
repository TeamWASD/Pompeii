﻿using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {

    private const string typeName = "Pompeii - GGJ15";
    private const string gameName = "RoomName";
    public GameObject playerPrefab = null;

    private void StartServer()
    {
        Network.InitializeServer(4, 25000, !Network.HavePublicAddress());
        MasterServer.RegisterHost(typeName, gameName);
    }

    void OnServerInitialized()
    {
        SpawnPlayer();
        Debug.Log("Server Initialized");
    }

    void OnGUI()
    {
        if (!Network.isClient && !Network.isServer)
        {
            if (GUI.Button(new Rect(100, 100, 100, 50), "Start Server"))
                StartServer();

            if (GUI.Button(new Rect(100, 175, 100, 50), "Refresh Hosts"))
                RefreshHostList();

            if (hostList != null)
            {
                for (int i = 0; i < hostList.Length; i++)
                {
                    if (GUI.Button(new Rect(250, 100 + (75 * i), 100, 50), hostList[i].gameName))
                        JoinServer(hostList[i]);
                }
            }
        }
    }

    private HostData[] hostList;
 
    private void RefreshHostList()
    {
        MasterServer.RequestHostList(typeName);
    }
 
    void OnMasterServerEvent(MasterServerEvent msEvent)
    {
        if (msEvent == MasterServerEvent.HostListReceived)
            hostList = MasterServer.PollHostList();
    }

    private void JoinServer(HostData hostData)
    {
        Network.Connect(hostData);
    }
 
    void OnConnectedToServer()
    {
        SpawnPlayer();
        Debug.Log("Server Joined");
    }

    private void SpawnPlayer()
    {
        Network.Instantiate(playerPrefab, new Vector3(0f, 5f, 0f), Quaternion.identity, 0);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
