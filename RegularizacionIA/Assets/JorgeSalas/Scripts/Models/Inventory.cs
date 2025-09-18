using UnityEngine;
using System.Collections.Generic;

public class Inventory
{
    public Map map;
    public List<Collection> abilities = new List<Collection>();
    public List<Collection> powerUps = new List<Collection>();
    public Dictionary<string, int> deathEnemies = new Dictionary<string, int>();
}
