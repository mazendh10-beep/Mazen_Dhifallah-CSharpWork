using ModuleC_.ISAMM.COCOJV.DTOs.UserDTOs;
using ModuleC_.ISAMM.COCOJV.Entities;
using ModuleC_.ISAMM.COCOJV.Repositories;
using ModuleC_.ISAMM.COCOJV.DTOs;


namespace ModuleC_.ISAMM.COCOJV.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public List<GetAllUserResponse> GetAll()
        {
            return _userRepository
                .GetAll()
                .Select(u => new GetAllUserResponse(u))
                .ToList();
        }

        public GetUserByIdResponse GetById(Guid id)
        {
            User user = _userRepository.GetById(id);
            if (user == null)
            {
                return null;
            }
            return new GetUserByIdResponse(user);
        }
        public void Post(PostUserResponse request)
        {
            User newUser = new User(
                Guid.NewGuid(),
                request.UserName,
                request.Email,
                request.Region,
                request.Age
            );
            _userRepository.Post(newUser);
        }

    }
}