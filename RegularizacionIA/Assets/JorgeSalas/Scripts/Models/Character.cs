using UnityEngine;

public class Character
{
    private int health;
    private float velocityMovement;
    private float damageHit;
    private float jumpHeight;
    private float cooldown;

    public int Health
    {
        get
        {
            return health;
        }
    }

    public float VelocityMovement
    {
        get
        {
            return velocityMovement;
        }
    }

    public float DamageHit
    {
        get
        {
            return damageHit;
        }
    }

    public float JumpHeight
    {
        get
        {
            return jumpHeight;
        }
    }

    public float Cooldown
    {
        get
        {
            return cooldown;
        }
    }
}
