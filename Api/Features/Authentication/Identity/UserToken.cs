﻿namespace Api.Features.Authentication.Identity;

public class UserToken
{
    public string Token { get; set; }
    public DateTime Expiration { get; set; }
}