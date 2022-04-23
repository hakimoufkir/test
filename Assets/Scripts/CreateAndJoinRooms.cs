using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;


    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
        Debug.Log("You are joining room name = " + joinInput.text);

    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
        Debug.Log("You are offically joined room name = " + joinInput.text);

    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("failed to join room name : " + joinInput.text + "code error" + returnCode + "    " + message);
    }
}

