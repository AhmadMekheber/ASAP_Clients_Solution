namespace ClientsDto.Dtos
{
    public record ClientDto(
        long ID,
        string FirstName,
        string LastName,
        string Email,
        string PhoneNumber
        );
}