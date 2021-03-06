﻿using System;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
    AttributeTargets.Enum | AttributeTargets.Method, AllowMultiple = false)] //  AllowMultiple = false => moje da se izpolzwa samo wednaj
class VersionAttribute : System.Attribute
{
    public int Major { get; private set; }
    public int Minor { get; private set; }

    public VersionAttribute(int major, int minor)
    {
        this.Major = major;
        this.Minor = minor;
    }
}