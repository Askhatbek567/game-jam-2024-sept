using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : ScriptableObject
{
    public Variable variableInitial;
    public float valueInitial;
    public Variable variableFinal;
    public float valueFinal;
    public float duration;
    public Variable variableCurrent;
    public float valueCurrent;
    public int times;
    public float valueShiftCurrent;

}

public enum Variable
{
    HP = 0,
    PosX = 1,
    PosY = 2,
    Speed = 3,
    Attack = 4,
    AttackSpeed = 5
}