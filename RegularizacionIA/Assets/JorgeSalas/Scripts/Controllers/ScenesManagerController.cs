using UnityEngine;
using System.Collections.Generic;

public class ScenesManagerController : MonoBehaviour
{
    public void SelectLevel()
    {
        GameManagerController.Instance.ChangeScenes("Level");
    }
}
