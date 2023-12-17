using System.Diagnostics.CodeAnalysis;
using System.Xml;
using System.Xml.Serialization;

namespace xmlObjectProvider.Objects.Models;

public record XmlTimeIntervalField()
{
    private DateTime? _startDate;
    private DateTime? _endDate;
    private string? _v;

    [SetsRequiredMembers]
    public XmlTimeIntervalField(DateTime startDate, DateTime endDate) : this() =>
        (_startDate, _endDate) = (startDate, endDate);

    [XmlIgnore]
    public required DateTime StartDate
    {
        get
        {
            if (_startDate.HasValue)
                return _startDate.Value;

            if (!string.IsNullOrEmpty(_v))
                _startDate = DateTime.Parse(V.Split('/')[0]).ToUniversalTime();

            return _startDate ?? throw new InvalidOperationException();
        }

        init => _startDate = value;
    }

    [XmlIgnore]
    public required DateTime EndDate
    {
        get
        {
            if (_endDate.HasValue)
                return _endDate.Value;

            if (!string.IsNullOrEmpty(_v))
                _endDate = DateTime.Parse(V.Split('/')[1]).ToUniversalTime();

            return _endDate ?? throw new InvalidOperationException();
        }

        init => _startDate = value;
    }

    [XmlAttribute(AttributeName = "v")]
    public string V
    {
        get
        {
            if (!string.IsNullOrEmpty(_v))
                return _v;

            _v = $"{StartDate:yyyy-MM-ddTHH:mmZ}/{EndDate:yyyy-MM-ddTHH:mmZ}";
            return _v;
        }

        init => _v = value;
    }

    public override string ToString() =>
        $"{StartDate:yyyy-MM-ddTHH:mmZ}/{EndDate:yyyy-MM-ddTHH:mmZ}";

    public static implicit operator XmlTimeIntervalField((DateTime startDate, DateTime endDate) period) => new(period.startDate, period.endDate);
}
