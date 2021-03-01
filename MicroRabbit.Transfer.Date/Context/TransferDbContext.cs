
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Date.Context
{
    public class TransferDbContext:DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}