public class BaseModels
{
    public int Id { get; set; }
    public string Name { get; set;}   // property
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public DateTime UpdatedAt {get; set;} = DateTime.Now;

}