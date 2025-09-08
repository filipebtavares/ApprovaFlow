using ApprovaFlow.Application.Models;
using ApprovaFlow.Core.Repositories;


namespace ApprovaFlow.Application.Services
{
    public  class UserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<ResultViewModel<List<RequestViewModel>>> GetAllRequest()
        {
            var request = await _repo.GetAllRequest();
            var model = request.Select(RequestViewModel.FromEntity).ToList();

            return ResultViewModel<List<RequestViewModel>>.Success(model);
        }

        public async Task<ResultViewModel<RequestItemViewModel>> GetRequestById(int id)
        {
            var request = await _repo.GetRequestId(id);

            if (request is null)
            {
                return ResultViewModel<RequestItemViewModel>.Error("Essa requisição de compra não pode ser encontrada.");
            }
        }
    }
}
