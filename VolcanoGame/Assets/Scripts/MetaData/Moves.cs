using UnityEngine;

[CreateAssetMenu(fileName = "MoveMetaData", menuName = "New Move", order = 1)]
public class Moves : ScriptableObject
{
    public string moveName;
    public string desc;
    public float dmg;
    public float energyCost;
    public string debuff;
    public float debuffMult;
}
