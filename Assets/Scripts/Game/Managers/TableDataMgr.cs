#region

using System.Collections.Generic;
using UnityEngine;

#endregion

/// <summary>
///     数据管理
/// </summary>
public class TableDataMgr : MonoBehaviour
{
    private BuffCfg buffCfg;
    private SkillCfg skillCfg;
    private GoodsCfg goodsCfg;
    private MonsterCfg monsterCfg;
    private EquipmentCfg equipmentCfg;

    private MonsterSkillCfg monsterSkillCfg;

    private List<TableDataBase> mLoadTables = new List<TableDataBase>();

    public static TableDataMgr Instance { get; private set; }

    /// <summary>
    ///     要加载的配置表
    /// </summary>
    public List<TableDataBase> LoadTables
    {
        get { return mLoadTables; }
        set { mLoadTables = value; }
    }

    private void Awake()
    {
        Instance = this;
        LoadTableData();
    }

    /// <summary>
    ///     初始化数据
    /// </summary>
    private void LoadTableData()
    {
        this.buffCfg = new BuffCfg("Buff");
        this.equipmentCfg = new EquipmentCfg("Equipment");
        this.goodsCfg = new GoodsCfg("Goods");
        this.monsterCfg = new MonsterCfg("Monster");
        this.monsterSkillCfg = new MonsterSkillCfg("MonsterSkill");
        this.skillCfg = new SkillCfg("Skill");
        foreach (TableDataBase t in mLoadTables)
        {
            ResMgr.Instance.Load(t.TableName, t);
        }
    }
}