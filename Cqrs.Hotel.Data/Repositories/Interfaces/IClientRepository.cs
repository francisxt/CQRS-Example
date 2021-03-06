﻿using System;
using Cqrs.Hotel.Domain.Model;

namespace Cqrs.Hotel.Data.Repositories.Interfaces
{
    public interface IClientRepository
    {
        Cliente GetById(Guid id);
    }
    public interface IRoomRepository
    {
        Habitacion GetById(Guid id);
    }
}