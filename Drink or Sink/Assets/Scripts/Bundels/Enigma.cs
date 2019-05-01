using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enigma : MonoBehaviour
{
    public BundleHandler bundleHandler;

    public void addBundle()
    {
        bundleHandler.AddChallenge("Challenge Enigma 1");
        bundleHandler.AddChallenge("Challenge Enigma 2");
        bundleHandler.AddChallenge("Challenge Enigma 3");
        bundleHandler.AddChallenge("Challenge Enigma 4");
        bundleHandler.AddChallenge("Challenge Enigma 5");

        SceneManager.LoadScene(1);
    }
}
