using System;
namespace XamarinWorkshop.DTO
{
    public record Branch(int Id, string Name, string Location);

    public record NewBranch(string Name, string Address);
}
