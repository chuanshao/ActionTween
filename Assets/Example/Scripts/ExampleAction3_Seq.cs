using SmileGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleAction3_Seq : ExampleRunTest
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

    public float mActionCurTime; //记录显示执行时间
    public float mActionExTime; //记录显示执行时间

    public bool m_AutoPlay;

    private float mTempTime;
    private SequenceAction m_SeqAction;

    private void Awake()
    {
       SeqTest();
    }

    public void SeqTest()
    {
        m_SeqAction = new SequenceAction();
        ActionTween mRotActionTween = this.transform.RotationTween(m_RotToValue, mDuration, m_RotModle);
        mRotActionTween
            .SetEase(mEaseType)
            .SetActionDirectionType(mDirectionType)
            .SetActionScaleTime(mScaleTime)
            .SetActionType(mActionType)
            .SetLoopTime(mLoopTime)
            .SetSpeedAble(m_UseSpeed)
            .SetSpeed(m_Speed)
            .SetRelative(m_Relative)
            .SetAutoKill(mAutoKill)
            .SetKillCallback(()=> 
            {
                LOG.Log("mRotActionTween Kill");
            })
            .SetCompleteCallback(()=> 
            {
               // LOG.Log("mRotActionTween Finish");
            });

        var moveAction = this.transform.MoveTween(mTargetTran, mDuration);
        moveAction
            .SetEase(mEaseType)
            .SetActionDirectionType(mDirectionType)
            .SetActionScaleTime(mScaleTime)
            .SetActionType(mActionType)
            .SetLoopTime(0)
            .SetSpeedAble(m_UseSpeed)
            .SetSpeed(m_Speed)
            .SetRelative(m_Relative)
            .SetAutoKill(mAutoKill);

        var colorAction = this.transform.ColorTween(Color.blue,mDuration);
        colorAction.SetActionType(mActionType);

        m_SeqAction.Add(0, mRotActionTween);
        m_SeqAction.Add(2, moveAction);
        m_SeqAction.Append(colorAction);
        m_SeqAction
           // .SetActionType(mActionType)
            .SetAutoKill(mAutoKill)
            .SetStepUpdateCallback(()=> 
            {
                mActionCurTime = Time.realtimeSinceStartup - mTempTime;
            })
            .SetBeginPlayCallback(() =>
            {
                mTempTime = Time.realtimeSinceStartup;
               // LOG.Log(this.gameObject.name + " anim Begin m_SeqAction");
            })
            .SetCompleteCallback(() =>
            {
                mActionExTime = Time.realtimeSinceStartup - mTempTime;
                //LOG.Log(this.gameObject.name + " anim Complete m_SeqAction");
            })
            .SetKillCallback(()=> 
            {
               LOG.Log(this.gameObject.name + " anim Kill m_SeqAction");
            });
        m_SeqAction.SetAutoPlay(m_AutoPlay);
        mTestActionTween = m_SeqAction;

    }


}
