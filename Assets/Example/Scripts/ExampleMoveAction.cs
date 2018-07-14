using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SmileGame;

public class ExampleMoveAction : ExampleRunTest {

    public Transform mTargetTran;
    public float mDuration;
    public ActionEnum.ActionDirectionType mDirectionType;
    public EaseEnum mEaseType;
    public float mScaleTime = 1;
    public ActionEnum.ActionType mActionType;
    public AnimationCurve m_AnimCurve;
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
        MoveToTest();
    }

    public void MoveToTest()
    {
        mTestActionTween = this.transform.MoveTween(mTargetTran, mDuration);
        mTestActionTween
            .SetEase(mEaseType)
            .SetActionDirectionType(mDirectionType)
            .SetActionScaleTime(mScaleTime)
            .SetActionType(mActionType)
            .SetAnimCurve(m_AnimCurve)
            .SetLoopTime(mLoopTime)
            .SetSpeedAble(m_UseSpeed)
            .SetSpeed(m_Speed)
            .SetRelative(m_Relative)
            .SetBeginPlayCallback(() =>
            {
                mTempTime = Time.realtimeSinceStartup;
                LOG.Log(this.gameObject.name + " anim Begin ");
            })
            .SetCompleteCallback(() =>
            {
                mActionExTime = Time.realtimeSinceStartup - mTempTime;
                LOG.Log(this.gameObject.name + " anim Complete ");
            })
            .SetAutoKill(mAutoKill)
            .SetKillCallback(() =>
            {
                LOG.Log(this.gameObject.name + " anim Kill Self ");
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
