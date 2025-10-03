using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GameManagerController : MonoBehaviour
{
    public string scenesList;
    private static GameManagerController instance;
    public static GameManagerController Instance 
    { 
        get
        {
            if (instance == null)
            {
                instance = FindAnyObjectByType<GameManagerController>();
                if (instance != null)
                {
                    return instance;
                }

                GameObject go = new GameObject();
                instance = go.AddComponent<GameManagerController>();
                DontDestroyOnLoad(go);
            }

            return instance;

        } 
    }

    public void ChangeScenes(int scenesList)
    {
        SceneManager.LoadScene(scenesList);
    }

}
