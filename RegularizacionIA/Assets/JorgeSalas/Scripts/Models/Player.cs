using UnityEngine;
using System.Collections.Generic;

public enum Ability { Dash, Run, DoubleJump, WallJump };

public class Player : Character
{
    private List<Ability> abilityType = new List<Ability>();
    private Dictionary<string, Inventory> inventory = new Dictionary<string, Inventory>();
    private Stats stadistics;
    private Rigidbody2D rb { get; set; }
    private Vector2 moveVector;

    public Player(Rigidbody2D rb) : base(5, 5)
    {
        this.rb = rb;
        moveVector = new Vector2();
    }

    public List<Ability> Ability
    {
        get
        {
            return abilityType;
        }
    }

    public Dictionary<string, Inventory> Inventory
    {
        get
        {
            return inventory;
        }
    }

    public Stats Stats
    {
        get
        {
            return stadistics;
        }
    }

    public void PlayerMovement(bool isGrounded)
    {
        moveVector = rb.linearVelocity;
        moveVector.x = 0;
        if (Input.GetKey(KeyCode.D)) moveVector.x = 1;
        
        if (Input.GetKey(KeyCode.A)) moveVector.x = -1;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) moveVector.y = JumpHeight;
        
        moveVector.x *= VelocityMovement;
        rb.linearVelocity = moveVector;
    }

    public void AddNewAbility(Ability ability)
    {
        abilityType.Add(ability);
    }
}
