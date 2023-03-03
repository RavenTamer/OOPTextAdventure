﻿namespace OOPAdventure;

public abstract partial class Language
{
    public string ChooseYourName { get; protected set; } = "";
    public string DefaultName { get; protected set; } = "";
    public string Welcome { get; protected set; } = "";
    public string DefaultRoomName { get; protected set; } = "";
    public string DefaultRoomDescription { get; protected set; } = "";
    public string ActionError { get; protected set; } = "";
    public string Go { get; protected set; } = "";
    public string GoError { get; protected set; } = "";
    public string WhatToDo { get; protected set; } = "";
    public string Quit { get; protected set; } = "";
    public string RoomNew { get; protected set; } = "";
    public string RoomOld { get; protected set; } = "";
    public string And { get; protected set; } = "";
    public string Space { get; protected set; } = "";
    public string Comma { get; protected set; } = "";
    public List<string> RoomDescriptions { get; protected set; }
    public string NoItem { get; protected set; } = "";
    public string Backpack { get; protected set; } = "";
    public string BackpackError { get; protected set; } = "";
    public string BackpackDescription { get; protected set; } = "";
    public string Chest { get; protected set; } = "";
    public string UnlockChest { get; protected set; } = "";
    public string Key { get; protected set; } = "";
    public string ChestEmpty { get; protected set; } = "";
    public string ChestFound { get; protected set; } = "";
}