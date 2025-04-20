using   ShitWithFriends.navigation.Navigation.Imp;

namespace ShitWithFriends.navigation.Navigation.Int;

public interface INavigationService
{
    Task GoBackAsync(object? parameters = null);
    Task GoToAsync<T>(object? parameters = null, bool? mantainFlyout = null) where T : Page;
    Task<TReturn?> ShowPopupAsync<TReturn, TViewModel>(object? dataToPass = null) where TReturn : class where TViewModel : MauiPopupViewModel;
}