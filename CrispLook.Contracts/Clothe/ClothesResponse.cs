namespace CrispLook.Contracts;

public record ClotheResponse(
    Guid Id,
    string Name,
    string Description,
    int Price,
    DateTime ProductionDate,
    DateTime LastModified,
    int Quantity,
    List<string> Sizes,
    List<string> Colors,
    List<string> Images
);