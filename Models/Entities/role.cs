using System.Globalization;

namespace Employee_Main.Models.Entities
{
    public class role
    {
        public Guid Id { get; set; } //= new Guid(); u can do this to create an new guid for an element but the entity takes care of that already
        public required string Role { get; set; }

        //This is an navigation property it is added when the property from this model is used in the other model 
        public ICollection<employee> Employees { get; set; }
        // this basically saying that for a particular role there can be many employee 
        // and this is given using the list 

    }
}
