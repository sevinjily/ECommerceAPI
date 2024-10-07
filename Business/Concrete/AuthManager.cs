using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.DTOs.AuthDTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthManager(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public Task<IResult> RegisterAsync(RegisterDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
