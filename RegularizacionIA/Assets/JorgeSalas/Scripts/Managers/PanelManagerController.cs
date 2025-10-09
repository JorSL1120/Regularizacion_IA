using System.Collections;
using UnityEngine;

public class PanelManagerController : MonoBehaviour
{
    public static PanelManagerController Instance { get; set; }
    public GameObject panelInstructions;
    public GameObject panelExit;
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    
    void Start()
    {
        panelInstructions.SetActive(true);
        panelExit.SetActive(false);
        StartCoroutine(DesactivateInstructions());
    }

    private IEnumerator DesactivateInstructions()
    {
        yield return new WaitForSeconds(2);
        panelInstructions.SetActive(false);
    }
}
