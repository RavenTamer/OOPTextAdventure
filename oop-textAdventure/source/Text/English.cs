﻿namespace OOPAdventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, what is your name ?";
        DefaultName = "Bob";
        Welcome = "Welcome {0} to your OOP Adventure";
        DefaultRoomName = "Room {0} ({1}, {2})";
        DefaultRoomDescription = " You are in a {0} room with doors to the {1}";
        ActionError = "You can't do that.";
        Go = "Go";
        GoError = "You can't go that way.";
        WhatToDo = "What do you want to do?";
        Quit = "quit";
        RoomNew = "You entered {0}.";
        RoomOld = "You returned to {0}.";
        And = "and";
        Space = " ";
        Comma = ",";
        RoomDescriptions = new List<string>
        {
            "normal",
            "cold",
            "warm",
            "dark",
            "bright",
            "scary",
            "strange",
        };
        NoItem = "You don't have {0}.";
        Backpack = "Backpack";
        BackpackError = "Your Backpack is empty.";
        BackpackDescription = "Your Backpack contains: {0}.";
        Chest = "chest";
        UnlockChest = "You unlocked the chest.";
        Key = "key";
        ChestEmpty = "The chest is empty.";
        ChestFound = "You found: {0}";
    }
}
