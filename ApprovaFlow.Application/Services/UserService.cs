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

            var model = RequestItemViewModel.FromEntity(request);
            return ResultViewModel<RequestItemViewModel>.Success(model);
        }


        public async Task<ResultViewModel<List<DecisionItemViewModel>>> GetAllDecision()
        {
            var decision = await _repo.GetAllDecisions();
            var model = decision.Select(DecisionItemViewModel.FromEntity).ToList();

            return ResultViewModel<List<DecisionItemViewModel>>.Success(model);
        }

        public async Task<ResultViewModel<DecisionItemViewModel>> GetDecisionById(int id)
        {
            var decision = await _repo.GetDecisionId(id);

            if (decision is null)
            {
                return ResultViewModel<DecisionItemViewModel>.Error("A decisão desta requisição não foi possivel ser encntrado");
            }

            var model = DecisionItemViewModel.FromEntity(decision);
            return ResultViewModel<DecisionItemViewModel>.Success(model);
        }

        public async Task<ResultViewModel<int>> CreateUser(CreateUserInputModel model)
        {
            var user = model.FromEntity();

            var createUser = await _repo.CreateUser(user);

            return ResultViewModel<int>.Success(user.Id);
        }

        public async Task<ResultViewModel> UpdateUser( UpdateUserInputModel userModel)
        {
            var user = await _repo.GetUserById(userModel.IdUser);

            if(user is null)
            {
                return ResultViewModel.Error("O usuário não foi encontrado.");
            }

            user.UpdateUser(userModel.FullName, userModel.Role, userModel.Cpf, userModel.Sector, userModel.Email);
            await _repo.UpdateUser(user);
            return ResultViewModel.Success();
        }
    }
}
