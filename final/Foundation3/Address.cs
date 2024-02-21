namespace InheritanceWithEventPlanning
{
    public class Address
    {
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public override string ToString()
        {
            return $"{streetAddress}, {city}, {stateProvince}, {country}";
        }
    }
}
