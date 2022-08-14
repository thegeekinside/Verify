﻿// ReSharper disable UseObjectOrCollectionInitializer

partial class SerializationSettings
{
    internal List<string> ignoredByNameMembers = new();

    public void IgnoreMember(string name)
    {
        Guard.AgainstNullOrEmpty(name, nameof(name));
        ignoredByNameMembers.Add(name);
    }

    public void IgnoreMembers(params string[] names)
    {
        Guard.AgainstNullOrEmpty(names, nameof(names));
        foreach (var name in names)
        {
            IgnoreMember(name);
        }
    }

    bool ShouldIgnoreByName(string name) =>
        ignoredByNameMembers.Contains(name);
}