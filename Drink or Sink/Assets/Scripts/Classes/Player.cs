using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public string Name { get; set; }
    public int Lives { get; set; }

    public Player(string name, int lives)
    {
        Name = name;
        Lives = lives;
    }
}
