using UnityEngine;
using System.Collections.Generic;

public enum Ability { Dash, Run, DoubleJump, WallJump };

public class Player : Character
{
    private List<Ability> abilityType = new List<Ability>();
    private Dictionary<string, Inventory> inventory = new Dictionary<string, Inventory>();
    private Stats stadistics;

    public Player()
    {

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

    }

    public void AddNewAbility(Ability ability)
    {
        abilityType.Add(ability);
    }
}
