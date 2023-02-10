using MediatR;

namespace TestWebApi.ApiFolder;

public class ApiHandler : IRequestHandler<ApiRequestModel, ApiResponseModel> {
    public async Task<ApiResponseModel> Handle(ApiRequestModel request, CancellationToken cancellationToken) {
        Console.WriteLine("Test");
        
        return new ApiResponseModel {
            Response = $"Number: {request.Number}",
        };
    }
}