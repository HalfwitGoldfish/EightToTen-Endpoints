namespace EightToTen_Endpoints.services
{
    public class RestaurantPickerServices
    {
        public string RestaurantPicker(string type)
        {
            string[] chinese = ["Golden Palace", "China Village", "Yen Du", "Sun Wong Kee", "The Chopstick", "Louies Chinese Restaurant", "Shermans Chinese Buffet", "Johnny Wokker", "New Shanghai", "M Kitchen Buffet"];
            string[] italian = ["Olive Garden", "Pietros", "De Vega Brothers", "Brick House Restaurant and Lounge", "Angelinas", "De Parsia Restaurant", "Noni Vita", "Nonas Restaurant", "De Vincis Delecatessen", "Mezzo"];
            string[] american = ["Flips Burgers", "Apple Bees Grill and Bar", "Fat City Brew and BBQ", "BJs Restaurant and Brewhouse", "Bourbon Street Bar and Grill", "El Rancho Inn Stake and Lobster House", "Heritage Dining and Provisions", "Victory Grill", "Waterloo Club", "Cast Iron Trading"];
            
            Random rng = new();
            int num = rng.Next(0, 9);
            if (type.ToLower() == "chinese")
                return $"I recommend {chinese[num]}";

            if (type.ToLower() == "italian")
                return $"i recommend {italian[num]}";

            if (type.ToLower() == "american")
                return $"i recommend {american[num]}";

            return $"the options are 'Chinese', 'Italian', and 'American'";
        }
    }
}