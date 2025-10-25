using UnityEngine;

[CreateAssetMenu(fileName = "ManalMoves", menuName = "PhysicalMoves", order = 1)]

public class ManaMoves : ScriptableObject
{
    string moveName;
    string desc;
    float dmg;
    float manaCost;
}
