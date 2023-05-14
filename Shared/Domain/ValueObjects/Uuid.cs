namespace Discord.Shared.Domain.ValueObjects;

public class Uuid
{
    public string Value { get; }

    protected Uuid(string value)
    {
        EnsureIsValidUuid(value);
        Value = value;
    }
    
    public static Uuid Random()
    {
        return new Uuid(Guid.NewGuid().ToString());
    }

    public override bool Equals(object? obj)
    {
        if (this == obj) return true;

        if (obj is not Uuid item) return false;

        return Value == item.Value;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Value);
    }

    public override string ToString()
    {
        return Value;
    }

    private void EnsureIsValidUuid(string value)
    {
        if (!Guid.TryParse(value, out _))
            throw new Exception($"{nameof(Uuid)} is not valid with value {value}");
    }
}