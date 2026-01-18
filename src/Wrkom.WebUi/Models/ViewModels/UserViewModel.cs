using Wrkom.ApplicationCore.Entities;

namespace Wrkom.WebUi.Models.ViewModels;

public class UserViewModel
{
    public string Username { get; set; } = string.Empty;
    public string DateOfBirth { get; set; } = string.Empty;

    public UserViewModel()
    {

    }

    public UserViewModel(User user)
    {
        Username = user.Username;
        DateOfBirth = user.DateOfBirth.ToString("yyyy/MM/dd");
    }
}