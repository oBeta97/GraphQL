using GraphQL.entities;
using HotChocolate.Types;

namespace GraphQL.graphQL;
public class UtenteType : ObjectType<User>
{
    protected override void Configure(IObjectTypeDescriptor<User> descriptor)
    {
        descriptor.Field(u => u.Role)
            .UseFiltering()
            .UseSorting();

        descriptor.Field(u => u.BankData)
            .UsePaging()
            .UseFiltering()
            .UseSorting();
    }
}
public class RuoloType : ObjectType<Role>
{
    protected override void Configure(IObjectTypeDescriptor<Role> descriptor)
    {
        descriptor.Field(r => r.Users)
            .UsePaging()
            .UseFiltering()
            .UseSorting();
    }
}
public class BankDataType : ObjectType<BankData>
{
    protected override void Configure(IObjectTypeDescriptor<BankData> descriptor)
    {
        descriptor.Field(b => b.User)
            .UseFiltering()
            .UseSorting();

        descriptor.Field(b => b.BankDetail)
            .UseFiltering()
            .UseSorting();
    }
}
public class BankDetailType : ObjectType<BankDetail>
{
    protected override void Configure(IObjectTypeDescriptor<BankDetail> descriptor)
    {
        descriptor.Field(b => b.BankData)
            .UseFiltering()
            .UseSorting();
    }
}