using Ncleverly.ObjectDb.Encryption.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Ncleverly.ObjectDb.Encryption.Services
{
    public class RandomUsersService
    {
        readonly string FunctionUrl = "https://randomuser.me";
        readonly IRandomUsersFunctions usersFunctions;

        public RandomUsersService()
        {          
            usersFunctions = RestService.For<IRandomUsersFunctions>(FunctionUrl);
        }

        public async Task<UserResponse> GetRandomUsers()
        {
            return await usersFunctions.GetRandomWebUsers();
        }
    }

    public interface IRandomUsersFunctions
    {
        [Get("/api/?results=5000")]
        Task<UserResponse> GetRandomWebUsers();
    }
}
