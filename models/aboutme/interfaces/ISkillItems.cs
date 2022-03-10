using System.Collections.Generic;

namespace SmallsOnline.Web.Lib.Models.AboutMe;

public interface ISkillItems
{
    string? Id { get; set; }
    string? PartitionKey { get; set; }
    List<string>? ITSkills { get; set; }
    List<string>? ProgrammingLanguages { get; set; }
}