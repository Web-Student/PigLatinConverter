using PigLatinClassLibrary1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHybridAppPigLatinConverter.Services;

internal class MauiPigLatinTranslatorService : IPigLatinTranslatorService
{
    public async Task<string> TranslateToPigLatin(string toTranslate)
    {
        HttpClient httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5292")
        };

        //call our controller on the web app to do the translation
        var response = await httpClient.GetStringAsync("/path");
        return response;
    }
}
