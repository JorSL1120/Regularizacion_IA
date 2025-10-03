using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
#if UNITY_EDITOR
    private void OnValidate()
    {
        if (thisRigidbody==null)
            thisRigidbody = GetComponent<Rigidbody2D>();
    }
#endif

    public static PlayerController Instance { get; private set; }
    public Player player;
    [SerializeField] private Rigidbody2D thisRigidbody;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            player = new Player(thisRigidbody);
        }
    }

    private void Update()
    {
        player.PlayerMovement();

        if (transform.position.x > 8)
        {
            MapController mapController = FindAnyObjectByType<MapController>();
            Vector2 currentPos = transform.position;
            currentPos.x = -7;
            transform.position = currentPos;
            mapController.LoadNextLevel();
        }
        else if (transform.position.x < -8)
        {
            MapController mapController = FindAnyObjectByType<MapController>();
            Vector2 currentPos = transform.position;
            currentPos.x = 7;
            transform.position = currentPos;
            mapController.LoadPreviousMap();
        }

    }
}
