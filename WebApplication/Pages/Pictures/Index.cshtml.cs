using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference;

namespace WebApplication.Pages.Pictures
{
    public class IndexModel : PageModel
    {
        MyInterfaceClient pcc = new MyInterfaceClient();
        public List<PictureDTO> Pictures { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public int resultCount;
        public IndexModel() { 
            Pictures = new List<PictureDTO>(); 
        }
        public async Task OnGetAsync()
        {
            var pictures = await pcc.getPicturesAsync("");
            if (!string.IsNullOrEmpty(SearchString))
            {
                pictures = await pcc.getPicturesAsync(SearchString);
            }
           
            resultCount = pictures.Count();
            
            foreach (var item in pictures)
            {
                PictureDTO pd = new PictureDTO();
                pd.name = item.name; 
                pd.type = item.type;
                pd.path = item.path;
                pd.creation_date = item.creation_date;
                pd.location = item.location;
                pd.persons = item.persons;
                pd.@event = item.@event;
                pd.other_details = item.other_details;
                Pictures.Add(pd);
            }
        }
    }
}