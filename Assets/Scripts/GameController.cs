using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    [HideInInspector] public RoomNavigation roomNavigation;

    // List of interactable objects
    [HideInInspector] public List<string> interactionDescriptionsInRoom = new();

    List<string> actionLog = new();
    
    void Awake()
    {
        roomNavigation = GetComponent<RoomNavigation>();
    }

    private void Start()
    {
        DisplayRoomText();
        DisplayLoggedText();
    }

    public void DisplayLoggedText()
    {
        string logAsText = string.Join("\n", actionLog.ToArray());
        displayText.text = logAsText;
    }

    public void DisplayRoomText()
    {
        // 2
        UnpackRoom();

        // 3
        // Add descriptions to our combined text
        string joinedInteractionDescriptions = string.Join("\n", interactionDescriptionsInRoom.ToArray());

        // 4
        string combinedText = roomNavigation.currentRoom.description + "\n" + joinedInteractionDescriptions;

        LogStringWithReturn(combinedText);
    }

    // 1
    void UnpackRoom()
    {
        roomNavigation.UnpackExitsInRoom();
    }

    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
