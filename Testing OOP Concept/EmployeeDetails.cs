namespace Modificatori_de_acces
{
    public class EmployeeDetails : Employee
    {
       public void SetDetails()
        {
            this.Name = "Maria";
            this.Id = 2;
            this.GetEmployeeDetails();
            base.Name = "gf";
        }
        public override string ToString()
        {
            return "Name:" + Name + " Id:" + Id;
        }
    }
}
