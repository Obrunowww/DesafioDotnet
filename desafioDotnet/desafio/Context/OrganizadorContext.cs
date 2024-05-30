using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio.Entities;
using Microsoft.EntityFrameworkCore;


namespace desafio.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        public DbSet<Atividade> Tarefas { get; set; }
    }
}