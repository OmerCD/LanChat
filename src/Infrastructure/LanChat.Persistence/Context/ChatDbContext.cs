using LanChat.Domain.Entities;
using LanChat.Persistence.Abstractions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LanChat.Persistence.Context;

public class ChatDbContext : IdentityDbContext<User, Role, int>, IChatDbContext
{
    public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options)
    {
    }

    public DbSet<ChatMessage> ChatMessages { get; set; }
}