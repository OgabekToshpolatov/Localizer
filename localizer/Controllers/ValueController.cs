using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace localizer.ValueController;

[ApiController]
[Route("api/[controller]")]
public class ValueController:ControllerBase
{
    private readonly ILogger<ValueController> _logger;
    private readonly IStringLocalizer<ValueController> _stringLocalizer;

    public ValueController(ILogger<ValueController> logger, IStringLocalizer<ValueController> stringLocalizer)
    {
        _logger = logger ;
        _stringLocalizer = stringLocalizer ;
    }

    [HttpGet]
    public IActionResult Culture(string culture)
    {
        return Ok(culture);
    }

    [HttpGet("culture-controller")]
    public IActionResult GetFromController(string culture = "uz")
    {
       HttpContext.Request.Headers.ContainsKey("Lang");

       string result =  HttpContext.Request.Headers["Lang"];

       var result1 =  _stringLocalizer["Data"].Value ;

       return Ok(_stringLocalizer["Data"].Value);
    }


}