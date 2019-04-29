using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public Button btnDone;
    public Button btnSkip;
    public Text txtChallenge;
    public Text txtHealt;
    public Text txtPlayer;

    private int randomPlayer;
    private int randomChallenge;
    private int previousPlayer = -1;

    private List<Player> listPlayer = GameControl.control.listPlayer;
    private List<Challenge> listChallenge = GameControl.control.listChallenges;

    // Start is called before the first frame update
    void Start()
    {
        nextPlayer();
    }

    public void nextPlayer()
    {
        do
        {
            randomPlayer = Random.Range(0, listPlayer.Count);
        }
        while (randomPlayer == previousPlayer);
        randomChallenge = Random.Range(0, listChallenge.Count);

        //Verander previous
        previousPlayer = randomPlayer;

        txtPlayer.text = listPlayer[randomPlayer].name;
        txtHealt.text = listPlayer[randomPlayer].lives.ToString();

        //change challenge
        txtChallenge.text = listChallenge[randomChallenge].title;
    }

    public void skipChallenge()
    {
        listPlayer[randomPlayer].lives = listPlayer[randomPlayer].lives - 1;

        if (listPlayer[randomPlayer].lives == 0)
        {
            listPlayer.RemoveAt(randomPlayer);

            if (listPlayer.Count == 1)
            {
                //Stop game
                endGame();
            }
        }

        if (listPlayer.Count != 1)
        {
            //Stop game
            nextPlayer();
        }
    }

    private void endGame()
    {
        
    }
}
