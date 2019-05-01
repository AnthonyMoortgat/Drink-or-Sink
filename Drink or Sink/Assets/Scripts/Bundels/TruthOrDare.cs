using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TruthOrDare : MonoBehaviour
{
    public BundleHandler bundleHandler;

    public void addBundle()
    {
        bundleHandler.AddChallenge("Challenge Truth or Dare 1");
        bundleHandler.AddChallenge("Challenge Truth or Dare 2");
        bundleHandler.AddChallenge("Challenge Truth or Dare 3");
        bundleHandler.AddChallenge("Challenge Truth or Dare 4");
        bundleHandler.AddChallenge("Challenge Truth or Dare 5");

        SceneManager.LoadScene(1);
    }
}
