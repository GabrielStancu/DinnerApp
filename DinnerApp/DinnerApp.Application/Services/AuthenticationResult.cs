using DinnerApp.Domain.Entities;

namespace DinnerApp.Application.Services;

public record AuthenticationResult(User User, string Token);