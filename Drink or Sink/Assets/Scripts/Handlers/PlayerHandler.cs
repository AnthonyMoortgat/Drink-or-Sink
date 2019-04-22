using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]

public class Player
{
    public string name;
    public int lives;
}

public class PlayerHandler : MonoBehaviour
{
    public InputField inputPlayer;
    public Transform contentPanel;
    public SimpleObjectPool simpleObjectPool;

    // Start is called before the first frame update
    void Start()
    {
        RefreshDisplay();
    }
    void RefreshDisplay()
    {
        fillPlayerList();
    }


    private void fillPlayerList()
    {
        foreach (Transform child in contentPanel.transform)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < GameControl.control.listPlayer.Count; i++)
        {
            Player player = GameControl.control.listPlayer[i];
            GameObject newPlayer = simpleObjectPool.GetObject();
            newPlayer.transform.SetParent(contentPanel);

            SampleButton sampleButton = newPlayer.GetComponent<SampleButton>();
            Debug.Log(sampleButton);
            sampleButton.Setup(player, this);
        }
    }
    public void AddPlayer()
    {
        if (inputPlayer.text != "")
        {
            //Create player with parameters
            Player player = new Player();
            player.name = inputPlayer.text;
            GameControl.control.listPlayer.Add(player);

            //Empty inputfield
            inputPlayer.text = "";

            //Refresh list
            RefreshDisplay();
        }
    }

    public void RemovePlayer(Player player)
    {
        for (int i = GameControl.control.listPlayer.Count - 1; i >= 0; i--)
        {
            if (GameControl.control.listPlayer[i] == player)
            {
                GameControl.control.listPlayer.RemoveAt(i);
            }
        }

        RefreshDisplay();
    }
}
