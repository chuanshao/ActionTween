﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SmileGame
{
    public static class ActionTweenIdBuilder
    {
        static uint mId = 0;

        public static uint CreateNewActionId()
        {
            return mId++;
        }
    }
}
