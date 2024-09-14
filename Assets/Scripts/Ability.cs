using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player;
public class Ability : ScriptableObject
{
    public AbilityHitboxType type;
    public float radius;
    public float width;
    public Effect effect;

}

public enum AbilityHitboxType
{
    Self,
    Circle,
    Square
}