using System.ComponentModel.DataAnnotations;

namespace service;

public class Product
{
    [MinLength(3)]
    public string ProductName { get; set; }
}