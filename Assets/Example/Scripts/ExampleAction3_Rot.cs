using SmileGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleAction3_Rot : ExampleRunTest
{
    public Vector3 m_RotToValue;
    public Transform mTargetTran;
    public float mDuration;
    public RotationAction.RotModle m_RotModle;
    public ActionEnum.ActionDirectionType mDirectionType;
    public EaseEnum mEaseType;
    public float mScaleTime = 1;
    public ActionEnum.ActionType mActionType;
    public int mLoopTime;
    public bool mAutoKill;
    public bool m_UseSpeed;
    public float m_Speed;
    public bool m_Relative;//相对关系
    public float m_AddSpeed; //叠加速度

    public float mActionExTime; //记录显示执行时间

    public bool m_AutoPlay;

    private float mTempTime;

    private void Awake()
    {
        RotToTest();
    }

    public void RotToTest()
    {
        mTestActionTween = this.transform.RotationTween(m_RotToValue, mDuration, m_RotModle);
       // mTestActionTween = this.transform.Rotation(mTargetTran, mDuration, m_RotModle);
        mTestActionTween
            .SetEase(mEaseType)
            .SetActionDirectionType(mDirectionType)
            .SetActionScaleTime(mScaleTime)
            .SetActionType(mActionType)
            .SetLoopTime(mLoopTime)
            .SetSpeedAble(m_UseSpeed)
            .SetSpeed(m_Speed)
            .SetRelative(m_Relative)
            .SetBeginPlayCallback(() =>
            {
                mTempTime = Time.realtimeSinceStartup;
               // LOG.Log(this.gameObject.name + " anim Begin ");
            })
            .SetCompleteCallback(() =>
            {
                mActionExTime = Time.realtimeSinceStartup - mTempTime;
               // LOG.Log(this.gameObject.name + " anim Complete ");
            })
            .SetAutoKill(mAutoKill)
            .SetKillCallback(() =>
            {
               // LOG.Log(this.gameObject.name + " anim Kill Self ");
            })
            .SetLoopCompleteCallback(() =>
            {
                // mTestActionTween.Kill();
                // mTestActionTween.ReCalDuration(mTestActionTween.mSpeed += m_AddSpeed);
               // LOG.Log("loop complete once");
            })
            .SetAutoPlay(m_AutoPlay);
    }
   
}
