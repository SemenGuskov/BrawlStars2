﻿using System;
using UnityEngine.Networking;

namespace I2.Loc
{
    public class TranslationJob : IDisposable
    {
        public eJobState mJobState = eJobState.Running;

        public enum eJobState { Running, Succeeded, Failed };

        public virtual eJobState GetState() { return mJobState; }

        public virtual void Dispose() { }

    }

    public class TranslationJob_WWW : TranslationJob
    {
        public UnityWebRequest www;

        public override void Dispose()
        {
            if (www != null)
                www.Dispose();
            www = null;
        }

    }
}