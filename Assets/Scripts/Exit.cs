using System;
using UnityEngine;

// It is very simple data class

[Serializable] // So that class would be displayed in the inspector
public class Exit
{
    // What are we going to be lookig for for exit (north, steps etc)
    // going to be put into a dic - that is why "key"
    public string keyString;

    // This is gonna be displayed in the action log
    public string exitDescription;

    // going to be put into a dic - that is why "value"
    public Room valueRoom;
}
