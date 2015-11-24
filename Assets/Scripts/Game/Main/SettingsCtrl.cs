#region

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#endregion

public class SettingsCtrl : BaseUI
{
    private Scrollbar mMusicBar;
    private Scrollbar mSoundBar;
    private List<string> mTranNames = new List<string> { "BtnContinue", "BtnExit", "MusicBar", "SoundBar" };
    private List<Transform> mTransforms = new List<Transform>();

    protected override void OnInit()
    {
        ComUtil.GetTransformInChild(mTranNames, CacheTransform, ref mTransforms);
        foreach (Transform tran in mTransforms)
        {
            if (tran.name.Equals(mTranNames[0]))
            {
                Button btn = tran.GetComponent<Button>();
                btn.onClick.AddListener(ButtonClickContinue);
            }
            else if (tran.name.Equals(mTranNames[1]))
            {
                Button btn = tran.GetComponent<Button>();
                btn.onClick.AddListener(ButtonClickExit);
            }
            else if (tran.name.Equals(mTranNames[2]))
            {
                mMusicBar = tran.GetComponent<Scrollbar>();
                mMusicBar.onValueChanged.AddListener(OnMusicValueChange);
            }
            else
            {
                mSoundBar = tran.GetComponent<Scrollbar>();
                mSoundBar.onValueChanged.AddListener(OnSoundValueChange);
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

    private void ButtonClickExit()
    {
        Log.Debug("1");
    }

    private void ButtonClickContinue()
    {
        Log.Debug("2");
    }

    private void OnMusicValueChange(float volume)
    {
    }

    private void OnSoundValueChange(float volume)
    {
    }

    #endregion
}