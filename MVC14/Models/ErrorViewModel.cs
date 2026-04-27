using System.ComponentModel.DataAnnotations;

namespace MVC14.Models
{
    public class ErrorViewModel
    {
        [Display(Name = "ID Yêu Cầu")]
        public string? RequestId { get; set; }

        [Display(Name = "Hiển Thị ID Yêu Cầu")]
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
