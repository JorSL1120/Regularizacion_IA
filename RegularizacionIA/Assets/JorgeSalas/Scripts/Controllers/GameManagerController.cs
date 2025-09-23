using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GameManagerController : MonoBehaviour
{
    public string scenesList;
    public static GameManagerController Instance{ get; set; }

    void Awake()
    {
        Instance = this;
    }

    public void ChangeScenes(string scenesList)
    {
        SceneManager.LoadScene(scenesList);
    }
}
