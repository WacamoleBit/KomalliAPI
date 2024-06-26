﻿using KomalliAPI.Clientes.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KomalliAPI.Contexts
{
    public class KomalliIdentityContext : IdentityDbContext<Cliente, IdentityRole<Guid>, Guid>
    {
        public KomalliIdentityContext(DbContextOptions<KomalliIdentityContext> options) : base(options) { }
    }
}
