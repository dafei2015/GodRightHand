#region

using System.Collections.Generic;
using LitJson;

#endregion

public class SkillCfg : TableDataBase
{
    private List<Skill> mSkills = new List<Skill>();

    public SkillCfg(string tableName)
        : base(tableName)
    {
    }

    protected override void ExtractJson(string json)
    {
        this.mSkills = JsonMapper.ToObject<List<Skill>>(json);
    }
}