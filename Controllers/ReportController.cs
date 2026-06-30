using Microsoft.AspNetCore.Mvc;
using Worker_Report.Services.Report;

namespace Worker_Report.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;
        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet("MasterData")]
        [Produces("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        [ProducesResponseType(typeof(FileContentResult), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetMasterData(
            [FromQuery] DateTime start,
            [FromQuery] DateTime end
        )
        {
            var (_, stream, fileName) = await _reportService.GetMasterData(start, end);

            return File(stream,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",fileName);
        }

        [HttpGet("MasterDataPribadi")]
        [Produces("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        [ProducesResponseType(typeof(FileContentResult), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetMasterDataPribadi(
            [FromQuery] DateTime start,
            [FromQuery] DateTime end
        )
        {
            var (_, stream, fileName) = await _reportService.GetMasterDataPribadi(start, end);

            return File(stream,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",fileName);
        }

        [HttpGet("Account")]
        [Produces("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        [ProducesResponseType(typeof(FileContentResult), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAccount(
            [FromQuery] DateTime start,
            [FromQuery] DateTime end
        )
        {
            var (_, stream, fileName) = await _reportService.GetAccount(start, end);

            return File(stream,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",fileName);
        }

        [HttpGet("Customer")]
        [Produces("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")]
        [ProducesResponseType(typeof(FileContentResult), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCustomer(
            [FromQuery] DateTime start,
            [FromQuery] DateTime end
        )
        {
            var (_, stream, fileName) = await _reportService.GetCustomer(start, end);

            return File(stream,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",fileName);
        }
    }
}
