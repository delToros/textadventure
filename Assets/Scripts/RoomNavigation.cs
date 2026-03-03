using UnityEngine;

public class RoomNavigation : MonoBehaviour
{
    // variable to recodrd what room we are in
    public Room currentRoom;

    // 1
    // We need controller because in it -> interactionDescriptionsInRoom
    GameController controller;

    // 2
    private void Awake()
    {
        controller = GetComponent<GameController>();
    }

    // 3
    public void UnpackExitsInRoom()
    {
        for (int i = 0; i < currentRoom.exits.Length; i++)
        {
            controller.interactionDescriptionsInRoom.Add(currentRoom.exits[i].exitDescription);
        }
    }
}
