class MyArrays
{
    public int x, y, z;
    public MyArrays(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public static bool operator false(MyArrays obj1)
    {
        if ((obj1.x % 2 == 0) || (obj1.y % 2 == 0) || (obj1.z % 2 == 0))
            return true;
        return false;
    }

    public static bool operator true(MyArrays obj1)
    {
        if ((obj1.x % 2 != 0) || (obj1.y % 2 != 0) || (obj1.z % 2 != 0))
            return false;
        return true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyArrays m = new MyArrays(3, 4, 5);
        if (m)
        {
            Console.WriteLine("Все числа четные");
        }
        else
        {
            Console.WriteLine("Не все числа четные");
        }
    }
}
