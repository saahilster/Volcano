using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "TEST_MoveMetaData", menuName = "New Test Move", order = 1)]
public class TestMoves : ScriptableObject
{
    public string moveName;
    public string desc;
    public Sprite icon;
}
