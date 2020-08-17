using CapsBallCore;
using GeoLib;

namespace CapsBallCore
{
    public class ItemData
    {
        public float Bounce { get; set; }
        public CollisionMask CollisionMask { get; set; }
        public string Name { get; set; }
        public ShapeStruct ShapeData { get; set; }
        public ShapeType ShapeType { get; set; }
        public string TexturePath { get; set; }

        public ItemData(string name, string line)
        {
            string[] data = line.Split(StadConstants.SEPARATOR_CHAR);
            ShapeType = data[0][0] == StadConstants.CIRCLE_ID ? ShapeType.CIRCLE : ShapeType.RECTANGLE;
            Bounce = float.Parse(data[1]);
            CollisionMask = getCollisionMaskFromChar(data[2][0]);
            Name = name;
            TexturePath = $"{StadConstants.STADIUMS_PATH}/{name}/{StadConstants.RESOURCES_PATH}{data[3]}";

            float x = float.Parse(data[4]);
            float y = float.Parse(data[5]);
            float w = ShapeType == ShapeType.RECTANGLE ? float.Parse(data[6]) : float.Parse(data[6]) / 2f;
            float h = ShapeType == ShapeType.RECTANGLE ? float.Parse(data[7]) : w;
            if (ShapeType == ShapeType.RECTANGLE)
                ShapeData = new RectStruct(x, y, w, h);
            else
                ShapeData = new CircStruct(x, y, w / 2);
        }

        CollisionMask getCollisionMaskFromChar(char data)
        {
            if (data == StadConstants.BALL_COLLISION_ID)
                return CollisionMask.COLLISION_BALL;
            else if (data == StadConstants.FULL_COLLISION_ID)
                return CollisionMask.COLLISION_FULL;

            return CollisionMask.COLLISION_PLAYER;
        }
    }
}
