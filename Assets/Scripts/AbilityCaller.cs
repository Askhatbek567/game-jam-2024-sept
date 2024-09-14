using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityCaller : ScriptableObject
{
    public AbilityType type;
    public AbilityExecuter executer;
    public int cooldown;
    public int currentCooldown;
}

public enum AbilityType    
{
    Player=0,
    Entity=1
}
