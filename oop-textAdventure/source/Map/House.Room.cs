namespace OOPAdventure;

public partial class House
{
    private int CalculateRoomIndex(int column, int row)
    {
        return Math.Clamp(column, -1, Width) + Math.Clamp(row, -1, Height) * Width;
    }
    public void CreateRooms(int width, int height)
    {
        Width = Math.Clamp(width, 2, 10);
        Height = Math.Clamp(height, 2, 10);

        var total = Width * Height;

        Rooms = new Room[total];

        for(int i = 0; i < total; i++)
        {
            Room tempRoom = new Room();

            int column = i % Width;
            int row = i / Width;

            tempRoom.Name = String.Format(Text.Language.DefaultRoomName, i, column, row);

            if (column < Width - 1)
            {
                tempRoom.Neigbours[Directions.East] = CalculateRoomIndex(column + 1, row);
            }
            if (column > 0)
            {
                tempRoom.Neigbours[Directions.West] = CalculateRoomIndex(column - 1, row);
            }
            if (row < Height - 1)
            {
                tempRoom.Neigbours[Directions.South] = CalculateRoomIndex(column, row + 1);
            }
            if(row > 0) 
            {
                tempRoom.Neigbours[Directions.North] = CalculateRoomIndex(column, row - 1);
            }

            Rooms[i] = tempRoom;
        }
    }
}