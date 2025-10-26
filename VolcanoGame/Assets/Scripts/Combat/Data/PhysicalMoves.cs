using UnityEngine;

[CreateAssetMenu(fileName = "PhysicalMoves", menuName = "PhysicalMoves", order = 0)]
public class PhysicalMoves : ScriptableObject {
    string moveName;
    string desc;
    float dmg;
    float hpCost;
    string statDebuff;
    float statMult;
}

