using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SiteAprendizadoDevOps.Pages
{
    public class IndexModel : PageModel
    {
        private const string SAUDACAO = "Olá!";
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            TempData["Saudacao"] = SAUDACAO;

            // Exibir horário no padrão brasileiro
            _logger.LogInformation(
                $"Requisição recebida em: {DateTime.UtcNow.AddHours(-3):HH:mm:ss.ffff} | " +
                $"Saudação: {SAUDACAO}");
        }
    }
}