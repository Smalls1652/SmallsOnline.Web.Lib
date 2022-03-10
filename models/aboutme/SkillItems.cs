using System.Collections.Generic;

namespace SmallsOnline.Web.Lib.Models.AboutMe;

public class SkillItems : ISkillItems
{
    public SkillItems()
    {}

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    [JsonPropertyName("itSkills")]
    public List<string>? ITSkills { get; set; }

    [JsonPropertyName("programmingLanguages")]
    public List<string>? ProgrammingLanguages { get; set; }
}