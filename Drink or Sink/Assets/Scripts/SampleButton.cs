using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleButton : MonoBehaviour
{

    public Button btnAddPlayer;
    public Text txtBtnPlayer;

    private Player player;
    private PlayerHandler playerHandler;

    // Use this for initialization
    void Start()
    {
        btnAddPlayer.onClick.AddListener(HandleClick);
    }

    public void Setup(Player currentPlayer)
    {
        player = currentPlayer;
        txtBtnPlayer.text = player.Name;
    }

    public void HandleClick()
    {
        /*scrollList.TryTransferItemToOtherShop(Player);*/
        // PlayerHandler.RemovePlayer(player);
        playerHandler.RemovePlayer(player);
    }
}