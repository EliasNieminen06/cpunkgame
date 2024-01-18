using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void play()
    {
        SceneManager.LoadScene("GameScene");
    }
}
