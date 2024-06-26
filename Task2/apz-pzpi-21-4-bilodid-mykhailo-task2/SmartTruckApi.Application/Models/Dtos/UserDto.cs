﻿using MongoDB.Bson;

namespace SmartTruckApi.Application.Models.Dtos;
public class UserDto
{
    public string Id { get; set; }

    public List<RoleDto> Roles { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? RefreshToken { get; set; }

    public DateTime? RefreshTokenExpiryDate { get; set; }

    public string CompanyId { get; set; }
}
