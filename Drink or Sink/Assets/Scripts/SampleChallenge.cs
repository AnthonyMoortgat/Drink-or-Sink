using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleChallenge : MonoBehaviour
{
    public Button btnChallenge;
    public Text txtBtnChallenge;

    private Challenge challenge;
    private ChallengeHandler challengeHandler;

    // Use this for initialization
    void Start()
    {
        btnChallenge.onClick.AddListener(HandleClick);
    }

    public void Setup(Challenge currentChallenge, ChallengeHandler challengeHandler)
    {
        challenge = currentChallenge;
        txtBtnChallenge.text = challenge.title;
        this.challengeHandler = challengeHandler;
    }

    public void HandleClick()
    {
        /*scrollList.TryTransferItemToOtherShop(Player);*/
        // PlayerHandler.RemovePlayer(player);
        challengeHandler.RemoveChallenge(challenge);
    }
}
