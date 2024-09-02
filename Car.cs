namespace GitHub_Test
{
    class Car
    {
        private string brand {  get; set; }

        private string model {  get; set; }

        private string horsepower { get; set; }

        private string mileage { get; set; }

        public void SetValues(string brand, string model, string horsepower, string mileage)
        {
            this.brand = brand;
            this.model = model;
            this.horsepower = horsepower;
            this.mileage = mileage;
        }

    }

}
