using EightToTen_Endpoints.services;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerServices _restaurantPickerServices;
        public RestaurantPickerController(RestaurantPickerServices restaurantPickerServices)
        {
            _restaurantPickerServices = restaurantPickerServices;
        }

        [HttpGet]
        [Route("RestaurantPicker/{type}")] 
        public string RestaurantPicker(string type)
        {
            return _restaurantPickerServices.RestaurantPicker(type);
        }
    }
}