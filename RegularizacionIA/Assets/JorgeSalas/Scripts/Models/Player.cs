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
    public Player(Rigidbody2D rb)
    {
        this.rb = rb;
        stadistics = new Stats();
        stadistics.Stat.Add("speed", 30f);

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

    public void PlayerMovement()
    {
        moveVector = rb.linearVelocity;
        moveVector.x = 0;
        if (Input.GetKey(KeyCode.D))
        {
            moveVector.x = 1;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            moveVector.x = -1;
        }

        rb.linearVelocity = moveVector;
    }

    public void AddNewAbility(Ability ability)
    {
        abilityType.Add(ability);
    }
}
