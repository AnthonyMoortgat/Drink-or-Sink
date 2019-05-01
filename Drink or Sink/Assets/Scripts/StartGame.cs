using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void startGame() {
        if (GameControl.control.listPlayer.Count >= 2 && GameControl.control.listChallenges.Count >= 1) {
            SceneManager.LoadScene(2);
        }
    }
}
