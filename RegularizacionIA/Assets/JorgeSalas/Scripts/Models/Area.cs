using UnityEngine;

public enum Enemies { Normal, Boss };

public class Area
{
    private Enemies enemiesType;
    private Stats characteristics;

    public Enemies Enemies
    {
        get
        {
            return enemiesType;
        }
    }

    public Stats Stats
    {
        get
        {
            return characteristics;
        }
    }
}
