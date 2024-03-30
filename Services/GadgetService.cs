using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TechTrendsShowcase.Models;

public class GadgetService
{
    private readonly string _jsonFilePath;

    public GadgetService(IWebHostEnvironment webHostEnvironment)
    {
        _jsonFilePath = Path.Combine(webHostEnvironment.WebRootPath, "data", "gadgets.json");
    }

    public IEnumerable<Gadget> GetGadgets()
    {
        using var jsonFileReader = File.OpenText(_jsonFilePath);
        return JsonSerializer.Deserialize<Gadget[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }
}
