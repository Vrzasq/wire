using System.Reflection;

namespace xmlProvider;

public record XmlObjectType(string Id)
{
    public static XmlObjectType ZGWM { get; } = new(nameof(ZGWM));
    public static XmlObjectType ZOEB { get; } = new(nameof(ZOEB));
    public static XmlObjectType ZOMB { get; } = new(nameof(ZOMB));
    public static XmlObjectType ZOPMB { get; } = new(nameof(ZOPMB));
    public static XmlObjectType ZOT { get; } = new(nameof(ZOT));
    public static XmlObjectType ZPP { get; } = new(nameof(ZPP));
    public static XmlObjectType ZUSE { get; } = new(nameof(ZUSE));
    public static XmlObjectType ZUSEB { get; } = new(nameof(ZUSEB));

    public static IEnumerable<XmlObjectType> GetAll()
    {
        return typeof(XmlObjectType).GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Select(x => (XmlObjectType)x.GetValue(null)!)!;
    }

    public static implicit operator string(XmlObjectType obj) => obj.Id;
    public static explicit operator XmlObjectType(string s) => new(s);

    public override string ToString() => Id;
}