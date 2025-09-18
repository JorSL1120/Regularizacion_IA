using UnityEngine;

public enum Ability { Dash, Run, DoubleJump, WallJump };

public class Player : Character
{
    public Ability abilityType;
    public Inventory inventory;
    public Stats stadistics;

    public void PlayerMovement()
    {

    }
}
