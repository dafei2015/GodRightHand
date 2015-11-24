#region

using System.Collections.Generic;
using UnityEngine;

#endregion

/// <summary>
///     ���ݹ���
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
    ///     Ҫ���ص����ñ�
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
    ///     ��ʼ������
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