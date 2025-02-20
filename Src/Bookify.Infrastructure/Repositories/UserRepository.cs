﻿using Bookify.Domain.Users;

namespace Bookify.Infrastructure.Repositories;

internal sealed class UserRepository(ApplicationDbContext dbContext) :Repository<User>(dbContext),IUserRepository
{
    
}