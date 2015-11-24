#region

using System.Collections.Generic;
using LitJson;

#endregion

public class MonsterSkillCfg : TableDataBase
{
    private List<MonsterSkill> mMonsterSkills = new List<MonsterSkill>();

    public MonsterSkillCfg(string tableName)
        : base(tableName)
    {
    }

    protected override void ExtractJson(string json)
    {
        this.mMonsterSkills = JsonMapper.ToObject<List<MonsterSkill>>(json);
    }
}