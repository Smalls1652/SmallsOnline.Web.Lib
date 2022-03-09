using System.Collections.Generic;

namespace SmallsOnline.Web.Lib.Models.AboutMe;

public class SkillItems : ISkillItems
{
    public SkillItems()
    {}

    [JsonPropertyName("itSkills")]
    public List<string>? ITSkills { get; set; }

    [JsonPropertyName("programmingLanguages")]
    public List<string>? ProgrammingLanguages { get; set; }
}