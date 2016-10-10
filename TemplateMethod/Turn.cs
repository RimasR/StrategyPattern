namespace TemplateMethod
{
    public class Turn
    {
        public string Way;

        public static Turn ReturnRight()
        {
            return new Turn() { Way = "Right" };
        }

        public static Turn ReturnLeft()
        {
            return new Turn() { Way = "Left" };
        }
    }
}