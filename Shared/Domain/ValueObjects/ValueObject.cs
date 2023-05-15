namespace Discord.Shared.Domain.ValueObjects;

public abstract class ValueObject<TPrimitive>
{
    public TPrimitive Value { get; }

    protected ValueObject(TPrimitive value)
    {
        Value = value;
    }

    public override bool Equals(object? obj)
    {
        if (this == obj) return true;

        if (obj is not ValueObject<TPrimitive> item) return false;

        return Value != null && Value.Equals(item.Value);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Value);
    }

    public override string ToString()
    {
        return Value?.ToString() ?? string.Empty;
    }
}