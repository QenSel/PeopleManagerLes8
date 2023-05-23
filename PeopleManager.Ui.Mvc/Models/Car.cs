namespace PeopleManager.Ui.Mvc.Models
{
    public class Car
    {
        public int id { get; set; }
        public required string lisencePlate { get; set; }
        public string? Type { get; set; }

        public string? Brand { get; set; }


        public int? ResponsiblePersonId { get; set; }
        //Oppassen met het = null! want het is nu mogelijk voor een nullexecption te vullen met niets
        public Person ResponsiblePerson { get; set; } = null!;

        
    }
}
