using System.Collections.Generic;
using UnityEngine;

public class RoomNavigation : MonoBehaviour
{
    // variable to recodrd what room we are in
    public Room currentRoom;

    // 1
    // Dictionary for interactivity
    Dictionary<string, Room> exitDictionary = new();

    // We need controller because in it -> interactionDescriptionsInRoom
    GameController controller;

    private void Awake()
    {
        controller = GetComponent<GameController>();
    }

    public void UnpackExitsInRoom()
    {
        for (int i = 0; i < currentRoom.exits.Length; i++)
        {
            // 2
            // add items to the dict
            exitDictionary.Add(currentRoom.exits[i].keyString, currentRoom.exits[i].valueRoom);

            controller.interactionDescriptionsInRoom.Add(currentRoom.exits[i].exitDescription);
        }
    }

    // 3
    void AttemptToChangeRooms(string directionNoun)
    {
        if (exitDictionary.ContainsKey(directionNoun))
        {
            // this is how we are changing rooms
            currentRoom = exitDictionary[directionNoun];
            controller.LogStringWithReturn($"You head of to {directionNoun}");
            controller.DisplayRoomText();
        }
        else
        {
            controller.LogStringWithReturn($"There is no path to the {directionNoun}");
        }
    }
}
