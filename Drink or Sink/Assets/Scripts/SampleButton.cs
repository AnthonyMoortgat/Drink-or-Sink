using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleButton : MonoBehaviour
{

    public Button btnPlayer;
    public Text txtBtnPlayer;

    private Player player;
    private PlayerHandler playerHandler;

    // Use this for initialization
    void Start()
    {
        btnPlayer.onClick.AddListener(HandleClick);
    }

    public void Setup(Player currentPlayer, PlayerHandler playerHandler)
    {
        player = currentPlayer;
        txtBtnPlayer.text = player.name;
        this.playerHandler = playerHandler;
    }

    public void HandleClick()
    {
        /*scrollList.TryTransferItemToOtherShop(Player);*/
        // PlayerHandler.RemovePlayer(player);
        playerHandler.RemovePlayer(player);
    }
}