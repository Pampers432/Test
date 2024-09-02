namespace GitHub_Test
{
    class Car
    {
        private string brand {  get; set; }

        private string horsepower { get; set; }

        private string mileage { get; set; }

        public void SetValues(string brand, string horsepower, string mileage)
        {
            this.brand = brand;
            this.horsepower = horsepower;
            this.mileage = mileage;
        }

    }
}
