using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public void OpenMainScene()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenGameScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);
    }
}
