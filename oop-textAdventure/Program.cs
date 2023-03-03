using OOPAdventure;

string name;
bool run = true;

Text.LoadLanguage(new English());

Console.WriteLine(Text.Language.ChooseYourName);
name = Console.ReadLine();

if(name == String.Empty)
{
    name = Text.Language.DefaultName;
}

Player player = new Player(name);
House house = new House(player);
Actions.Instance.Register(new Go(house));
Actions.Instance.Register(new Backpack(player));
Room lastRoom = null;

house.CreateRooms(3, 3);
house.DecorateRooms();

var items = new List<Item>()
{
    new Key(house),
    new Chest(new[] {new Gold(100)}, house)
};

house.PopulateRooms(items);

house.GoToStartingRoom();

Console.WriteLine(Text.Language.Welcome, player.Name);

while(run)
{
    string input;

    if (lastRoom != house.CurrentRoom)
    {
        Console.WriteLine(house.CurrentRoom.ToString());
        lastRoom = house.CurrentRoom;
    }
    Console.WriteLine(Text.Language.WhatToDo);
    input = Console.ReadLine().ToLower();

    if(input == Text.Language.Quit)
    {
        run = false;
    }
    else
    {
        Actions.Instance.Execute(input.Split(" "));
    }
}
