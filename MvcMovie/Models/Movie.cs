using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; } = default;
    
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
    public DateTime ReleaseDate { get; set; } = default;

    public string? Genre { get; set;} = default;

    [DataType(DataType.Currency)]
    public decimal Price { get; set; } = default;
}