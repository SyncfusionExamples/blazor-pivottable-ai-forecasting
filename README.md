# 🚀 Predict Future Trends with Syncfusion Blazor Pivot Table
Welcome to this exciting demo! This GitHub repository shows how to power up the [Syncfusion Blazor Pivot Table](https://www.syncfusion.com/blazor-components/blazor-pivot-table) with Azure OpenAI to predict future trends using historical data. Whether you’re forecasting sales, inventory, or resources, this project makes it easy to gain actionable insights.

## ✨ What You’ll Build
AI-Driven Forecasting: Predict future data points (e.g., bike sales for FY 2026) based on past trends, with forecasted values highlighted in the Pivot Table for clarity.

## 📋 Prerequisites
Before you start, ensure you have:

- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) or later with .NET 7.0 or higher.
- An Azure OpenAI Service account with an API key and endpoint.
- A basic understanding of Blazor and C#.

## 🛠️ Getting Started
Let’s get forecasting in just a few steps!

1. Clone the Repository
Grab the code by cloning this repo:

    ```bash
    git clone https://github.com/SyncfusionExamples/blazor-pivottable-ai-forecasting
    cd blazor-pivottable-ai-forecasting
    ```

2. Set Up the Project
- Open BlazorAI.sln in Visual Studio 2022.
- Restore NuGet packages: Right-click the solution in Solution Explorer and select Restore NuGet Packages.
- Build the solution (Ctrl+Shift+B or Build → Build Solution).

3. Configure Azure OpenAI
In Services/OpenAIService.cs, replace the placeholder azureEndpoint and azureApiKey with your Azure OpenAI credentials:
csharp

```
    var azureEndpoint = "your-azure-endpoint-url";
    var azureApiKey = "your-api-key";
```

4. Run and Explore
- Press F5 to launch the app.
- The Pivot Table will load with sample bike sales data.
- Click the AI Assist button, pick a future year (e.g., 2026), and see the forecasted data highlighted in yellow!

## 📚 Resources
- Syncfusion Blazor Pivot Table [Documentation](https://blazor.syncfusion.com/documentation/pivot-table/getting-started-webapp)
- Azure OpenAI Service [Documentation](https://azure.microsoft.com/en-us/products/ai-services/openai-service?msockid=274934ada8c86a3e0fce2060a9c86bc5)