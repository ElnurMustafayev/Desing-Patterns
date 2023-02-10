using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestWebApi.ApiFolder;

namespace TestWebApi.Controllers {

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase {

        protected readonly ISender mediator;

        public HomeController(ISender mediator) {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponseModel>> Method(int number) {
            try {
                var request = new ApiRequestModel { Number = number };
                return await this.mediator.Send(request);
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
