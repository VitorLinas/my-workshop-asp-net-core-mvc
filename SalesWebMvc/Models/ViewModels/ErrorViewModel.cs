using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Models.ViewModels;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}