public class Visit :BaseModels{
    public int MemberId { get; set;}
    public Member? Member { get; set;}
    public DateTime? CheckOutTime {get; set;}
    public List<Resource>? VisitResources {get; set;}

}