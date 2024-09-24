using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.Views.Shared.Components._AdminHead
{
    public class _AdminPreloader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
