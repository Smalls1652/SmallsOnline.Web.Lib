using System.Collections.Generic;

namespace SmallsOnline.Web.Lib.Models.AboutMe;

public interface ISkillItems
{
    List<string>? ITSkills { get; set; }
    List<string>? ProgrammingLanguages { get; set; }
}