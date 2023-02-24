namespace CrispLook.Contracts
{
    public record CreateClotheRequest(
        string Name,
        string Description,
        int Price,
        DateTime ProductionDate,
        int Quantity,
        List<string> Sizes,
        List<string> Colors,
        List<string> Images
    );
}