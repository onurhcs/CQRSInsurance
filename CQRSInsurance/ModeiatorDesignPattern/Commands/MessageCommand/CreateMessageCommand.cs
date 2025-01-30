using MediatR;
using System.ComponentModel.DataAnnotations;

namespace CQRSInsurance.ModeiatorDesignPattern.Commands.MessageCommand
{
    public class CreateMessageCommand : IRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Project { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string MessageText { get; set; }
    }
}
