#region

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#endregion

public class MainScene : BaseUI,UIMgr.ILoadUIListener
{
    private Scrollbar mExpBar;
    private Text mExpText;
    private List<string> mTranNames = new List<string> {"BtnMenu", "BtnTask", "BtnFigure", "ExpBar", "TextExp"};
    private List<Transform> mTransforms = new List<Transform>();

    protected override void OnInit()
    {
        ComUtil.GetTransformInChild(mTranNames, CacheTransform, ref mTransforms);
        foreach (Transform tran in mTransforms)
        {
            if (tran.name.Equals(mTranNames[0]))
            {
                Button btn = tran.GetComponent<Button>();
                btn.onClick.AddListener(ButtonClickMenu);
            }
            else if (tran.name.Equals(mTranNames[1]))
            {
                Button btn = tran.GetComponent<Button>();
                btn.onClick.AddListener(ButtonClickTask);
            }
            else if (tran.name.Equals(mTranNames[2]))
            {
                Button btn = tran.GetComponent<Button>();
                btn.onClick.AddListener(ButtonClickFigure);
            }
            else if (tran.name.Equals(mTranNames[3]))
            {
                mExpBar = tran.GetComponent<Scrollbar>();
            }
            else
            {
                mExpText = tran.GetComponent<Text>();
            }
        }
    }

    protected override void OnAwake()
    {
        base.OnAwake();
    }

    protected override void OnShow(object param)
    {
        base.OnShow(param);
    }

    protected override void OnHide()
    {
        base.OnHide();
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
    }

    #region 按钮点击事件

    private void ButtonClickMenu()
    {
        UIMgr.Instance.ShowUI(UIDef.SettingsUI,typeof(SettingsCtrl),this);
    }

    private void ButtonClickTask()
    {
        Log.Debug("2");
    }

    private void ButtonClickFigure()
    {
        Log.Debug("3");
    }

    #endregion

    public void FiniSh(BaseUI ui)
    {
    }

    public void Failure()
    {
    }
}