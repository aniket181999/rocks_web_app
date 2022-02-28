using System.Web.Mvc;

namespace Info.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        IEnumerable<SelectListItem> CategorySelectList { get; set;  }
    }
}
