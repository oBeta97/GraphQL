using GraphQL.dbContext;
using GraphQL.entities;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;

namespace DemoGraphQL.GraphQL;
public class Query
{
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<User> Utenti([Service] AppDbContext ctx) =>
        ctx.Users.Include(u => u.Role).Include(u => u.BankData).ThenInclude(db => db.BankDetail);

    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Role> Ruoli([Service] AppDbContext ctx) =>
        ctx.Roles;

    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<BankData> BankDatas([Service] AppDbContext ctx) =>
        ctx.BankDatas.Include(b => b.User).Include(b => b.BankDetail);

    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public IQueryable<BankDetail> BankDetails([Service] AppDbContext ctx) =>
        ctx.BankDetails;
}
