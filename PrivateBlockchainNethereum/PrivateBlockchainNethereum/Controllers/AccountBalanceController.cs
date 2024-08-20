using Microsoft.AspNetCore.Mvc;

namespace PrivateBlockchainNethereum.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountBalanceController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public AccountBalanceController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAccountBalanceAsync")]
    public  string Get()
    {
        return "0";
    }

}

