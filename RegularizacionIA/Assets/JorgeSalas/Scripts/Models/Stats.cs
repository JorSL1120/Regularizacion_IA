using UnityEngine;
using System.Collections.Generic;

public class Stats
{
    private Dictionary<string, object> stats = new Dictionary<string, object>();

    public Dictionary<string, object> Stat    
    {
        get
        {
            return stats;
        }
    }
}
