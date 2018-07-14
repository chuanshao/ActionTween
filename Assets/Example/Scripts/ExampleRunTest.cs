using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SmileGame;

public class ExampleRunTest : MonoBehaviour {

    protected ActionTween mTestActionTween;

    public void Play()
    {
        if (mTestActionTween != null)
        {
            mTestActionTween.Play();
        }
        else
        {
            LOG.Log("mTestActionTween can not Statr ");
        }
    }

    public void RePlay()
    {
        if (mTestActionTween != null)
        {
            mTestActionTween.RePlay();
        }
        else
        {
            LOG.Log("mTestActionTween can not Statr ");
        }
    }

    public void Revert()
    {
        if (mTestActionTween != null)
        {
            mTestActionTween.Revert();
        }
        else
        {
            LOG.Log("mTestActionTween can not Statr ");
        }
    }

    public void Pause()
    {
        if (mTestActionTween != null)
        {
            mTestActionTween.Pause();
        }
        else
        {
            LOG.Log("mTestActionTween can not Statr ");
        }
    }

    public void Resume()
    {
        if (mTestActionTween != null)
        {
            mTestActionTween.Resume();
        }
        else
        {
            LOG.Log("mTestActionTween can not Statr ");
        }
    }

    public void Reset()
    {
        if (mTestActionTween != null)
        {
            mTestActionTween.Reset();
        }
        else
        {
            LOG.Log("mTestActionTween can not Statr ");
        }
    }

    public void Kill()
    {
        if (mTestActionTween != null)
        {
            mTestActionTween.Kill();
            mTestActionTween = null;
        }
        else
        {
            LOG.Log("mTestActionTween can not Statr ");
        }
    }

}
