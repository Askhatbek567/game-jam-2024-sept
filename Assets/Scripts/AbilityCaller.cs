using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityCaller : ScriptableObject
{
    public AbilityType type;
    public Ability ability;
    public int times;
    public int interval;
    public int cooldown;
    public int currentCooldown;


}

public enum AbilityType    
{
    Player,
    Entity
}
