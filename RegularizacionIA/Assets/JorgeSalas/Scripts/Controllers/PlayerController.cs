using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }
    public Player player;
    
    private Rigidbody2D thisRigidbody;
    private bool isGrounded = false;

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
            thisRigidbody = GetComponent<Rigidbody2D>();
            player = new Player(thisRigidbody);
        }
    }

    private void Update()
    {
        player.PlayerMovement(isGrounded);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Tilemap tilemap = collision.gameObject.GetComponent<Tilemap>();
        if (tilemap != null)
        {
            isGrounded = true;
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        Tilemap tilemap = collision.gameObject.GetComponent<Tilemap>();
        if (tilemap != null)
        {
            isGrounded = false;
        }
    }
}
