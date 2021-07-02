using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ViewComponentsCountires.ViewComponents
{
    public class Async : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            const string website = "https://www.google.com";
            var client = new HttpClient();
            var response = await client.GetAsync(website);

            return Content($"The size of {website} is " +
                           $"{response.Content.Headers.ContentLength.ToString()} bytes");
        }
    }
}
