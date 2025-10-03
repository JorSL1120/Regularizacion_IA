using UnityEngine;
using System.Collections.Generic;

public class ScenesManagerController : MonoBehaviour
{
    public void SelectLevel(int levelToSelect)
    {
        GameManagerController.Instance.ChangeScenes(levelToSelect);
    }
}
