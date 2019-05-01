using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BundleHandler : MonoBehaviour
{
    public void AddChallenge(string title)
    {
        //Create player with parameters
        Challenge challenge = new Challenge();
        challenge.title = title;
        GameControl.control.listChallenges.Add(challenge);
    }
}
