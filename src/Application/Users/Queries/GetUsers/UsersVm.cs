﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NfcPos.Application.Users.Queries.Common;

namespace NfcPos.Application.Users.Queries.GetUsers;
public class UsersVm
{
    public IList<UserDto> users { get; set; } = new List<UserDto>();
    
}
