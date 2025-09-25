using UnityEngine;
using System.Collections.Generic;

public class Stats
{
    private Dictionary<string, string> stats = new Dictionary<string, string>();

    public Dictionary<string, string> Stat    
    {
        get
        {
            return stats;
        }
    }
}
