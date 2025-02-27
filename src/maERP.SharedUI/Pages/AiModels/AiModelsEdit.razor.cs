using System.Net.Http.Json;
using maERP.Domain.Dtos.AiModel;
using maERP.Domain.Wrapper;
using maERP.SharedUI.Contracts;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace maERP.SharedUI.Pages.AiModels;

public partial class AiModelsEdit
{
    [Inject]
    public required NavigationManager NavigationManager { get; set; }
    
    [Inject]
    public required ISnackbar Snackbar { get; set; }

    [Inject]
    public required IHttpService HttpService { get; set; }


    [Parameter]
    public int aiModelId { get; set; }

    // ReSharper disable once NotAccessedField.Local
    MudForm? _form;

    // ReSharper disable once NotAccessedField.Local
    protected string Title = "Bearbeiten";

    public AiModelDetailDto AiModelDetail = new();

    protected override async Task OnParametersSetAsync()
    {
        if (aiModelId != 0)
        {
            var result = await HttpService.GetAsync<Result<AiModelDetailDto>>($"/api/v1/AiModels/{aiModelId}");
            
            if (result != null && result.Succeeded)
            {
                AiModelDetail = result.Data;
            }
            else
            {
                // Handle error case
                AiModelDetail = new AiModelDetailDto();
            }
        }
    }

    protected async Task Save()
    {
        var httpResponseMessage = await HttpService.PutAsJsonAsync<AiModelDetailDto>($"/api/v1/AiModels/{aiModelId}", AiModelDetail);
        var result = await httpResponseMessage.Content.ReadFromJsonAsync<Result<int>>() ?? null;

        if (result != null)
        {
            if (result.Succeeded)
            {
                NavigateToList();
                Snackbar.Add("AI Model gespeichert", Severity.Success);
            }
            else
            {
                foreach (var errorMessage in result.Messages)
                {
                    Snackbar.Add(errorMessage, Severity.Error);
                }
            }
        }
        else
        {
            Snackbar.Add("AI Model konnte nicht gespeichert werden", Severity.Error);
        }
    }

    public void NavigateToList()
    {
        StateHasChanged();
        NavigationManager.NavigateTo("/AiModels");
    }
}