﻿using System;

namespace UnityEngine
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class DisableAttribute : ToolboxConditionAttribute
    { }
}