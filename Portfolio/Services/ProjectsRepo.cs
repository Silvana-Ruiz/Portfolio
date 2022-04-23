using Portfolio.Models;

namespace Portfolio.Services
{
    public interface IProjectsRepo
    {
        List<ProjectDTO> GetProjectDTOs();
    }
    public class ProjectsRepo : IProjectsRepo
    {
        public List<ProjectDTO> GetProjectDTOs()
        {
            return new List<ProjectDTO>() {
                new ProjectDTO
            {
                Title = "Amazon",
                Description =  "E-commerce website build with ASP.NET Core",
                Link = "https://amazon.com",
                ImageURL = "/img/amazon.png"
            },
                new ProjectDTO

            {
                Title = "New York Times",
                Description =  "News site build with React",
                Link = "https://nytimes.com",
                ImageURL = "/img/nyt.png"
            },
                new ProjectDTO
            {
                Title = "Reddit",
                Description =  "Social media to share with communities",
                Link = "https://reddit.com",
                ImageURL = "img/reddit.png"
            },
                new ProjectDTO
            {
                Title = "Steam",
                Description =  "Online store to buy videogames",
                Link = "https://store.steanpowered.com",
                ImageURL = "ing/steam.png"
            }

            };
        }
    }
}
