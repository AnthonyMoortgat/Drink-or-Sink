using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dare : MonoBehaviour
{
    public BundleHandler bundleHandler;

    public void addBundle()
    {
        bundleHandler.AddChallenge("Challenge Dare 1");
        bundleHandler.AddChallenge("Challenge Dare 2");
        bundleHandler.AddChallenge("Challenge Dare 3");
        bundleHandler.AddChallenge("Challenge Dare 4");
        bundleHandler.AddChallenge("Challenge Dare 5");

        SceneManager.LoadScene(1);
    }
}
