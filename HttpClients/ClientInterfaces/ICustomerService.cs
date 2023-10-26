﻿using Domain.DTOs;

namespace HttpClients.ClientInterfaces;

public interface ICustomerService
{
    Task CreateAsync(CustomerCreationDTO dto);
}