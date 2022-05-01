using LanChat.Domain.Entities;
using LanChat.Persistence.Abstractions;
using LanChat.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LanChat.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<IChatDbContext, ChatDbContext>(builder => builder.UseSqlite("Data Source=chat.db"));
        services.AddIdentity<User, Role>().AddEntityFrameworkStores<ChatDbContext>();
        return services;
    }
}