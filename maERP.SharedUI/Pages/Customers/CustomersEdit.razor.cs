using maERP.SharedUI.Models.Customer;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace maERP.SharedUI.Pages.Customers;

public partial class CustomersEdit
{

    [Parameter]
    public int customerId { get; set; }

    private MudForm? _form;

    protected string Title = "hinzufügen";

    protected CustomerVM customer = new();

    protected override async Task OnParametersSetAsync()
    {
        if (customerId != 0)
        {
            customer = await _customerService.GetCustomerDetails(customerId);
        }
    }

    protected async Task Save()
    {
        await _customerService.UpdateCustomer(customerId, customer);

        ReturnToList();
    }

    public void ReturnToList()
    {
        StateHasChanged();
        _navigationManager.NavigateTo("/Customers");
    }
}