namespace BuberDinner.Contracts.Authentication;

public record AuthentitcationResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token);