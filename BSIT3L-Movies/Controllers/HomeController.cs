using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<MovieViewModel> _movies;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _movies = new List<MovieViewModel>
           {
                new MovieViewModel { Id = 1, Name = "Barbie in the Nutcracker", Rating = "5", ReleaseYear = 2001, Genre = "Fantasy, Musical", ImageUrl ="https://pp.userapi.com/c845219/v845219258/de31e/Pm7zckdsAhc.jpg", BSource ="https://www.youtube.com/watch?v=Gvdya_iEJ28"},
                new MovieViewModel { Id = 2, Name = "Barbie as Rapunzel", Rating = "4", ReleaseYear = 2002, Genre = "Fantasy, Musical", ImageUrl ="https://pp.userapi.com/c845219/v845219258/de325/HMkf6tvO3TI.jpg", BSource="https://www.youtube.com/watch?v=FdObIxS1CPk"},
                new MovieViewModel { Id = 3, Name = "Barbie of Swan Lake", Rating = "5", ReleaseYear = 2003, Genre = "Fantasy, Musical", ImageUrl ="https://pp.userapi.com/c850136/v850136727/18125/zPuR88R1raE.jpg", BSource="https://www.youtube.com/watch?v=wtbN5G6mrtA" },
                new MovieViewModel { Id = 4, Name = "Barbie as the Princess and the Pauper", Rating = "4", ReleaseYear = 2004, Genre = "Musical, Romance", ImageUrl ="https://pp.userapi.com/c850136/v850136727/18187/v_PZHhTczcI.jpg", BSource="https://www.youtube.com/watch?v=3mAoYCwGilY" },
                new MovieViewModel { Id = 5, Name = "Barbie Fairytopia", Rating = "5", ReleaseYear = 2005, Genre = "Animation, Adventure", ImageUrl ="https://pp.userapi.com/c850136/v850136727/181ba/L9WEtSs22fc.jpg", BSource="https://www.youtube.com/watch?v=pITEecVKOeE" },
                new MovieViewModel { Id = 6, Name = "The Barbie Diaries", Rating = "3", ReleaseYear = 2006, Genre = "Animation, Comedy", ImageUrl ="https://pp.userapi.com/c850136/v850136727/181fa/Y9fS8ra8OjI.jpg", BSource="https://www.youtube.com/watch?v=zRpHClE69A4" },
                new MovieViewModel { Id = 7, Name = "Barbie And The Diamond Castle", Rating = "5", ReleaseYear = 2008, Genre = "Animation, Fantasy", ImageUrl ="https://pp.userapi.com/c850136/v850136727/182b9/gu1LlntCpLQ.jpg", BSource="https://www.youtube.com/watch?v=pFGK_MP4Nmk" },
                new MovieViewModel { Id = 8, Name = "Barbie: A Fashion Fairytale", Rating = "4", ReleaseYear = 2010, Genre = "Animation, Family", ImageUrl ="https://pp.userapi.com/c850136/v850136727/1830a/dy-Jf7OYsuM.jpg", BSource="https://www.youtube.com/watch?v=Ph094YzC9-A" },
                new MovieViewModel { Id = 9, Name = "Barbie: A Fairy Secret", Rating = "5", ReleaseYear = 2011, Genre = "Animation, Family", ImageUrl ="https://pp.userapi.com/c850136/v850136727/1831b/tLXkTC9BIP0.jpg", BSource="https://www.youtube.com/watch?v=QfER_KfKkNE" },
                new MovieViewModel { Id = 10, Name = "Barbie: The Princess and the Popstar", Rating = "4", ReleaseYear = 2012, Genre = "Animation, Musical", ImageUrl ="https://pp.userapi.com/c850136/v850136481/1850b/Y_vvuQWKSa4.jpg", BSource="https://www.youtube.com/watch?v=lTCqkFNs8b8"},
                new MovieViewModel { Id = 11, Name = "Barbie and Chelsea the Lost Birthday", Rating = "3", ReleaseYear = 2021, Genre = "Animation, Family", ImageUrl ="https://sun9-10.userapi.com/impg/_v6sWkGotAcH5m6wilXX_QRioSUU-Gt2HZpZjg/jvuHDQnsEdI.jpg?size=300x425&quality=96&sign=b76cdf4401f75ce02588a3b8ea271d17&type=album", BSource="https://www.youtube.com/watch?v=2xU6_8Z0Ohc" },
                new MovieViewModel { Id = 12, Name = "Barbie: Big City, Big Dreams", Rating = "4", ReleaseYear = 2022, Genre = "Animation, Musical", ImageUrl ="https://sun9-14.userapi.com/impg/RdEkXJj42s9gqVDjr3enHTQYrFfMvEA0YeosuA/Uj0wxddclpo.jpg?size=300x425&quality=95&sign=545ef583535d2a01fef16c98e2e00f8c&type=album", BSource="https://www.youtube.com/watch?v=npeZdlb-L4o" },
                new MovieViewModel { Id = 13, Name = "Barbie: Mermaid Power", Rating = "5", ReleaseYear = 2021, Genre = "Animation, Fantasy", ImageUrl ="https://sun9-67.userapi.com/impg/Isl2bHAvuam3paQcVIqe8sQp0iBhlVMlA_PByA/YuIX1WFsWAw.jpg?size=300x425&quality=95&sign=cca7bbccdc5964969d60ee6d1c4e4d82&type=album", BSource="https://www.youtube.com/watch?v=4WJge5gXjfk" },
                new MovieViewModel { Id = 14, Name = "Barbie: Skipper and the Big Babysitting Adventure", Rating = "1", ReleaseYear = 2023, Genre = "Animation, Family", ImageUrl ="https://sun9-17.userapi.com/impg/3PUSmgfw_HVUcIfJ-j68qd-c9Ge2Z6mpuhq39Q/AhX2-pFlEr4.jpg?size=300x425&quality=95&sign=f95f0f1323e4a880058ac3c688227214&type=album", BSource="https://www.youtube.com/watch?v=mPI3IbFaa9g" },
                new MovieViewModel { Id = 15, Name = "Barbie Princess Adventure", Rating = "2", ReleaseYear = 2020, Genre = "Animation, Musical", ImageUrl ="https://sun9-73.userapi.com/tt6kVspWthn91SeHFyUjM2tii5Eh7I61KwB6gA/fBlqSPYUMEs.jpg", BSource="https://www.youtube.com/watch?v=7joR5V_T3wQ" }
            };
        }

        public IActionResult Index()
        {
            return View(_movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
