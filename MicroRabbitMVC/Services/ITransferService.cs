using System.Net.Mime;
using System.Threading.Tasks;
using MicroRabbitMVC.Models.DTO;

namespace MicroRabbitMVC.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDTO transferDto);
    }
}