namespace Proxy.Models;

public class Translation {
    public string? FromText { get; set; }
    public string? ToText { get; set; }
    
    public string? FromLang { get; set; }
    public string? ToLang { get; set; }

    public override string ToString() => $"'{this.FromText}' ({this.FromLang}) => ({this.ToLang}) '{this.ToText}'";
}