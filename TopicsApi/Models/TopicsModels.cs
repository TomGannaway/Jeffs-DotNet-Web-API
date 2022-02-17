﻿using System.ComponentModel.DataAnnotations;

namespace TopicsApi.Models;

/*{
  "data": [
    {
      "id": "1", "name": "Angular is Fun", "description": "Angular Stuff For Me To Read About"
    },
    { "id": "2", "name": "Services", "description": "Services Reading Stuff"}
  ]
}
*/

public record TopicListItemModel(
    //[property:Required]
    string id,
    //[property:Required]
    //[property: MaxLength(10)]
    string name, 
    //[property: Required]
    string description);

public record GetTopicsModel(IEnumerable<TopicListItemModel> data);


// {name: "Line Dancing", description: "Resources about Line Dancing"}

public record PostTopicRequestModel(
    [MinLength(3)]
    [MaxLength(20)]
    string name,
    [MinLength(1)]
    [MaxLength(200)]
    string description);

//public record PostTopicRequestModel : IValidatableObject
//{
//    [Required]
//    [MinLength(3)]
//    [MaxLength(20)]
//    public string Name { get; init; } = "";


//    [Required]
//    [MinLength(1)]
//    [MaxLength(200)]
//    public string Description { get; init; } = "";

//    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
//    {
//        if (Name.Trim().ToLowerInvariant() == Description.Trim().ToLowerInvariant())
//        {
//            yield return new ValidationResult("Name and Description Cannot be the same!", new string[] { nameof(Name), nameof(Description) });
//        }
//    }
//}

//public record Person(string firstName, string lastName);

//public record Person2
//{
//    public string firstNAme { get; init; }
//    public string lastName { get; init; }
//}

//var p = new Person("Jeff", "Gonzalez");

//var p2 = new Person2 { firstNAme = "Henry", lastName = "Gonzalez" };