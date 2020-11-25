using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("WelcomeScene");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("FinishScene");
    }
}



