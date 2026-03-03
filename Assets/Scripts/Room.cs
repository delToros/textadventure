using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/Room")]
public class Room : ScriptableObject
{
    [TextArea]
    public string description;
    public string roomName;
    
    // this added
    public Exit[] exits;
}
