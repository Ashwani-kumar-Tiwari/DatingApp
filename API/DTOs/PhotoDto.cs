namespace API.DTOs;

public class PhotoDto
{
    public int ID {get; set;}
    public required string Url {get; set;}
    public bool IsMain {get; set;}
}