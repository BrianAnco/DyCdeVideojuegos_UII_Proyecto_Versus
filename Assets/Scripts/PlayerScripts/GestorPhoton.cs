using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GestorPhoton : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        //Comprobamos el archivo de Photon y poder conectarnos al servidor.
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void OnConnectedToMaster()
    {
        //Conexión al servidor.
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        //Nos unimos a un lobby en els ervidor de Photon. Ingresamos Nombre, Cantidad de Jugadores y el Tipo.
        PhotonNetwork.JoinOrCreateRoom("Cuarto", new RoomOptions { MaxPlayers = 4 }, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        //Cuando nos unamos al cuarto, ingresamos lo que va a crear, la ubicación y la rotación.
        PhotonNetwork.Instantiate("Player", new Vector2(-0.92f, -0.23f), Quaternion.identity);
    }
}

