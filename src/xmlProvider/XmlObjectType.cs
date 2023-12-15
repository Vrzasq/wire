using System.Reflection;

namespace xmlProvider;

public record XmlObjectType(string Id)
{

    public static XmlObjectType ZGWM { get; } = new(nameof(ZGWM));
    public static XmlObjectType ZOEB { get; } = new(nameof(ZOEB));
    public static XmlObjectType ZOMB { get; } = new(nameof(ZOMB));

    /// <summary>
    /// Oferta portfolio na moce bilansujące 
    /// </summary>
    public static XmlObjectType ZOPMB { get; } = new(nameof(ZOPMB));
    public static XmlObjectType ZOT { get; } = new(nameof(ZOT));

    /// <summary>
    /// Program pracy 
    /// </summary>
    public static XmlObjectType ZPP { get; } = new(nameof(ZPP));

    /// <summary>
    /// Umowa sprzedaży energuu dnia następnego
    /// </summary>
    public static XmlObjectType ZUSE { get; } = new(nameof(ZUSE));

    /// <summary>
    /// Umowa sprzedaży energii dnia bierzącego
    /// </summary>
    public static XmlObjectType ZUSEB { get; } = new(nameof(ZUSEB));

    public static IEnumerable<XmlObjectType> GetAll()
    {
        return typeof(XmlObjectType).GetProperties(BindingFlags.Public | BindingFlags.Static)
            .Select(x => (XmlObjectType)x.GetValue(null)!)!;
    }

    public static implicit operator string(XmlObjectType obj) => obj.Id;
    public static implicit operator XmlObjectType(string s) => new(s);

    public override string ToString() => Id;
}