using Microsoft.AspNetCore.Razor.TagHelpers;
using RestaurantManagementApp.Models;
using System.Collections.Generic;

namespace RestaurantManagementApp.TagHelpers
{
    public class MenuItemsTagHelper : TagHelper
    {
        public List<MenuItem> Items { get; set; } = new();
        public List<int> SelectedIds { get; set; } = new();
        public string? Name { get; set; } 

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "row");

            foreach (var item in Items)
            {
                var isChecked = SelectedIds.Contains(item.Id) ? "checked" : "";
                output.Content.AppendHtml($@"
                    <div class='col-md-4 col-lg-3 mb-4'>
                        <div class='menu-item-card form-check shadow-sm rounded p-3 h-100'>
                            <input type='checkbox' class='form-check-input' name='{Name}' value='{item.Id}' id='menu-item-{item.Id}' {isChecked} />
                            <label class='form-check-label ml-2' for='menu-item-{item.Id}'>
                                <strong>{item.Name}</strong>
                                <span class='d-block text-muted'>{item.Price.ToString("C", new System.Globalization.CultureInfo("tr-TR"))}</span>
                            </label>
                        </div>
                    </div>
                ");
            }
        }
    }
}
