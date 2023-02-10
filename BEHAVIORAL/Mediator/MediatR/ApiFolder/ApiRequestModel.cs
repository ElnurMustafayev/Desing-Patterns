using MediatR;

namespace TestWebApi.ApiFolder;

public class ApiRequestModel : IRequest<ApiResponseModel> {
    public int Number { get; set; }
}