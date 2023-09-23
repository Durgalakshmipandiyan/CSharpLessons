using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWind.Models
{
    public class OrderIdsViewModel
    {
        public int Id { get; set; } //for the selected item. ie one id for the dropdown
        public readonly List<SelectListItem> OrderIdsSelectedList;
       public OrderIdsViewModel(List<int> orderIds)
        {
            OrderIdsSelectedList = new List<SelectListItem>();
            foreach (var no in orderIds)
            {
                OrderIdsSelectedList.Add(new SelectListItem { Text = $"{no}", Value = $"{no}" });
            }
        }

    }
}
