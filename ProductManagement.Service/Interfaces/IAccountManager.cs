using Newtonsoft.Json.Linq;
using ProductManagement.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Service.Interfaces
{
    public interface IAccountManager
    {
        void Register(RegisterDTO registerDto);
        JObject Login(LoginDTO loginDto);
    }
}
