namespace Api_Web
{
    public class Personne
    {
  //      public int Id { get; set; } 
        public string? Name { get; set; }

        public string? FirstName { get; set; }

   //     public string? Email { get; set; }

      //  public string? Password { get; set; }

        public static bool TryParse(string value , out Personne? person)
        {
            try
            {
                var data = value.Split(',');
                person = new Personne
                { 
                    Name = data[0],
                    FirstName = data[1]
                };
                return true;
            }
            catch(Exception)
            {
                person = null;
                return false;
            }
        }

        public async Task<Personne> BindAsync(HttpContext context, ParameterInfo parameterInfo)
        {
            
        }
    }
}
