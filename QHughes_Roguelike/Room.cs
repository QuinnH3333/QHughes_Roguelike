namespace QHughes_Roguelike
{
    class Room
    {
        private Enemy roomEnemy;
        private string roomName;
        private string roomDescription;

        public Enemy Enemy
            { get { return roomEnemy; } }
        public string Name
        {
            get { return roomName; }
        }
        public string Description
        {
            get { return roomDescription; }
        }

        public Room(string initName, string initDescription, Enemy? initRoomEnemy = null)
        {
            if (initRoomEnemy != null)
            {  roomEnemy = initRoomEnemy; }
            roomName = initName;
            roomDescription = initDescription;
        }
    }
}
