using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataBase : ScriptableObject
{
    public int HP;
    public float Speed;
    public float Attack;
    public float AttackSpeed;
    public List<Effect> effects;
    public List<Ability> abilities;
}
