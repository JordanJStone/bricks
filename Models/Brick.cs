namespace bricks.Models
{
  public class Brick
  {

    public int Id { get; set; }
    public string Color { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }



    // Do we need the constructor?
    public Brick(int id, string color, string name, string description)
    {
      Id = id;
      Color = color;
      Name = name;
      Description = description;
    }
  }
}