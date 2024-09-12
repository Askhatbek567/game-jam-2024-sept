using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : ScriptableObject
{
    public AbilityType type;
    public float radius;
    public float width;
    public Effect effect;
}

public enum AbilityType
{
    Circle,
    Square
}