using ServiceContracts;

namespace Services
{
  public class CitiesService : ICitiesService
  {
    private List<string> _cities;

    public CitiesService()
    {
      _cities = new List<string>() { 
        "Bangalore",
        "kumta",
        "New Delhi",
        "Pune",
        "Mumbai"
      };
    }

    public List<string> GetCities()
    {
      return _cities;
    }
  }
}
