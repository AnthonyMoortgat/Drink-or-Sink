using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Truth : MonoBehaviour
{
    public BundleHandler bundleHandler;

    public void addBundle()
    {
        bundleHandler.AddChallenge("Challenge Truth 1");
        bundleHandler.AddChallenge("Challenge Truth 2");
        bundleHandler.AddChallenge("Challenge Truth 3");
        bundleHandler.AddChallenge("Challenge Truth 4");
        bundleHandler.AddChallenge("Challenge Truth 5");

        SceneManager.LoadScene(1);
    }
}
