using System;

namespace SearchTrailers.Data.Domain.Shared;

public abstract class EntityId : IEquatable<EntityId>, IComparable<EntityId>
{
    protected object ObjValue { get; }

    public string Value
    {
        get
        {
            if (ObjValue.GetType().Equals(typeof(string)))
                return (string)ObjValue;
            return AsString();
        }
    }

    public int CompareTo(EntityId other)
    {
        if (other == null)
            return -1;
        return Value.CompareTo(other.Value);
    }


    public bool Equals(EntityId other)
    {
        if (other == null)
            return false;
        if (GetType() != other.GetType())
            return false;
        return Value == other.Value;
    }

    protected abstract string AsString();
}