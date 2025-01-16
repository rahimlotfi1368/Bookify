namespace Bookify.Domain.Shared;

public record Currency()
{
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("EUR");
    public static readonly Currency None = new("");

    private Currency(string code) : this() => Code = code;
    public string Code { get; init; }

    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        Usd,
        Eur
    };

    public static Currency FromCode(string code) => All.FirstOrDefault(c => c.Code == code) ??
                                                    throw new ApplicationException("The currency code is invalid");
}