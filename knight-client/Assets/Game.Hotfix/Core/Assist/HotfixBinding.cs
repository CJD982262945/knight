﻿//======================================================================
//        Copyright (C) 2015-2020 Winddy He. All rights reserved
//        Email: hgplan@126.com
//======================================================================
using System;
using UnityEngine;
using Object = UnityEngine.Object;
using Knight.Framework;

namespace Knight.Hotfix.Core
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class HotfixBindingAttribute : Attribute
    {
        public string           Name;
        public int              Index;

        public HotfixBindingAttribute(string rName = "")
        {
            this.Name           = rName;
        }

        public HotfixBindingAttribute(int nIndex = -1)
        {
            this.Index          = nIndex;
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class HotfixBindingEventAttribute : Attribute
    {
        public string               Name;
        public HEventTriggerType    EventType;
        public bool                 NeedUnbind;

        public HotfixBindingEventAttribute(string rName, HEventTriggerType rEventType, bool bNeedUnbind = true)
        {
            this.Name           = rName;
            this.EventType      = rEventType;
            this.NeedUnbind     = bNeedUnbind;
        }
    }

    public class HotfixEventObject
    {
        public Object               TargetObject;
        public Action<Object>       EventHandler;
        public HEventTriggerType    EventType;
        public bool                 NeedUnbind;
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class HotfixEventAttribute : Attribute
    {
        public int                  MsgCode;

        public HotfixEventAttribute(int nMsgCode)
        {
            this.MsgCode = nMsgCode;
        }
    }
}
