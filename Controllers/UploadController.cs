using Microsoft.AspNetCore.Mvc;

namespace UploadLargeFileNet8.Controllers;

[ApiController]
[Route("[controller]")]
public class UploadController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<UploadController> _logger;

    public UploadController(ILogger<UploadController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Upload")]
    public IEnumerable<Star> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Star
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpPost]
    public async Task<IActionResult> Post(IFormFile file)
    {
        string fileName = file.FileName;
        using (var stream = System.IO.File.Create(fileName))
        {
            await file.CopyToAsync(stream);
        }

        return Ok();
    }
}
