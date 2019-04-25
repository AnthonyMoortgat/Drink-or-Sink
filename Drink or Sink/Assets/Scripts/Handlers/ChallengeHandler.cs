using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]

public class Challenge {
    public string title;
}

public class ChallengeHandler : MonoBehaviour
{
    public InputField inputChallenge;
    public Transform contentPanel;
    public SimpleObjectPool simpleObjectPool;

    // Start is called before the first frame update
    void Start()
    {
        RefreshDisplay();
    }

    void RefreshDisplay()
    {
        fillChallengeList();
    }

    private void fillChallengeList()
    {
        foreach (Transform child in contentPanel.transform)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < GameControl.control.listChallenges.Count; i++)
        {
            Challenge challenge = GameControl.control.listChallenges[i];
            GameObject newChallenge = simpleObjectPool.GetObject();
            newChallenge.transform.SetParent(contentPanel);

            SampleChallenge sampleChallenge = newChallenge.GetComponent<SampleChallenge>();
            sampleChallenge.Setup(challenge, this);
        }
    }
    public void AddChallenge()
    {
        if (inputChallenge.text != "")
        {
            //Create player with parameters
            Challenge challenge = new Challenge();
            challenge.title = inputChallenge.text;
            GameControl.control.listChallenges.Add(challenge);

            //Empty inputfield
            inputChallenge.text = "";

            //Refresh list
            RefreshDisplay();
        }
    }

    public void RemoveChallenge(Challenge challenge)
    {
        for (int i = GameControl.control.listChallenges.Count - 1; i >= 0; i--)
        {
            if (GameControl.control.listChallenges[i] == challenge)
            {
                GameControl.control.listChallenges.RemoveAt(i);
            }
        }

        RefreshDisplay();
    }
}
