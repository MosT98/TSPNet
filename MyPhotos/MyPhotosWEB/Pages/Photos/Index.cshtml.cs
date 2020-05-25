using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyPhotosWEB.Models;
using ServiceReferenceMyPhotos;

namespace MyPhotosWEB.Pages.Photos
{
    public class IndexModel : PageModel
    {
        MyPhotosClient myPhotosClient = new MyPhotosClient();
        private readonly MyPhotosWEB.Data.MyPhotosWEBContext _context;
        public IList<PhotoDTO> Photos { get; set; }

        public string SearchName { get; set; }
        public string SearchLocation { get; set; }
        public string SearchDescription { get; set; }
        //public DateTime SearchDate { get; set; }
        public bool DeleteFilter { get; set; }
        public int Counter { get; set; }
        public string Filter { get; set; }


        public IndexModel(MyPhotosWEB.Data.MyPhotosWEBContext context)
        {
            _context = context;
            Photos = new List<PhotoDTO>();
        }

        
        public async Task OnGetAsync()
        {
            var photos = await myPhotosClient.GetPhotosAsync();
            //Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<Photo, PhotoDTO>());
            //Map the objects
            var mapper = new Mapper(config);
            Photos = mapper.Map<List<Photo>, List<PhotoDTO>>(photos);
            Counter = Photos.Count();
            Filter = "";
        }

        public async Task OnPostAsync()
        {
            SearchName = Request.Form["SearchName"];
            SearchLocation = Request.Form["SearchLocation"];
            SearchDescription = Request.Form["SearchDescription"];
            //SearchDate = DateTime.Parse(Request.Form["SearchDate"]);
            DeleteFilter = Request.Form["DeleteFilter"] == "y" ? true : false;

            if (DeleteFilter)
            {
                SearchName = null;
                SearchLocation = null;
                SearchDescription = null;
                //SearchDate = default(DateTime);
            }

            var photos = await myPhotosClient.GetPhotosAsync();
            var config = new MapperConfiguration(mc => mc.CreateMap<Photo, PhotoDTO>());
            var mapper = new Mapper(config);

            Photos = mapper.Map<List<Photo>, List<PhotoDTO>>(photos);

            if (SearchName!=null && SearchName !=string.Empty)
            {
                Photos = Photos.Where(p => p.Name.ToUpper().Contains(SearchName.ToUpper())).ToList();
                Filter += "Name: " + SearchName + ";";
            }
            if (SearchLocation!=null && SearchLocation!=string.Empty)
            {
                Photos = Photos.Where(p => p.Location.ToUpper().Contains(SearchLocation.ToUpper())).ToList();
                Filter += "Location: " + SearchLocation + ";";
            }
            if (SearchDescription!=null && SearchDescription!=string.Empty)
            {
                Photos = Photos.Where(p => p.Description.ToUpper().Contains(SearchDescription.ToUpper())).ToList();
                Filter += "Description: " + SearchDescription + ";";
            }

            Counter = Photos.Count();
        }
    }
}
