class Wall
{
    public float Height;
    public float Width;
    public string Material;

    public Wall(float height, float width, string material)
    {
        this.Height = height;
        this.Width = width;
        this.Material = material;
    }
    public float GetSurface()
    {
        return Width * Height;
    }
    public void PrintInfo()
    {
        Console.WriteLine("Vyska: " + Height);
        Console.WriteLine("Sirka: " + Width);
        Console.WriteLine("Material: " + Material);
        Console.WriteLine("Povrch: " + GetSurface());
    }
}