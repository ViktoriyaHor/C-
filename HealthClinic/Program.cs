namespace HealthClinic;

class Program
{
    static void Main(string[] args)
    {

        // Predefined roles
        Role adminRole = new Role(RoleType.Admin);
        Role doctorRole = new Role(RoleType.Doctor);
        Role userRole = new Role(RoleType.User);

        User user = new User("Alice", "Johnson", "alice.johnson@example.com");
        Admin admin = new Admin("Jane", "Smith", "jane.smith@example.com");
        Doctor doctor = new Doctor("John", "Doe", "john.doe@example.com");

        Appointment appointment = new Appointment
        {
            StartDate = DateTime.Now.AddDays(1),
            EndDate = DateTime.Now.AddDays(1).AddHours(2),
            Description = "Follow-up checkup",
            Doctor = doctor,
            User = user
        };
    }
}

public enum RoleType
{
    User,
    Doctor,
    Admin
}

public class Role
{
    public int Id { get; set; }
    public RoleType RoleType { get; set; }

    public string getRoleType()
    {
        return RoleType;
    }
}

class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Role Role { get; set; }
    public User(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Role = new Role { RoleType = RoleType.User };
    }

    public void assignRole(Role role)
    {
        this.role = role;
    }


    public string getRoleType()
    {
        return Role.getRoleType();
    }
}
public class Admin : User
{

    public Admin(string firstName, string lastName, string email)
        : base(firstName, lastName, email)
    {
        Role = new Role { RoleType = RoleType.Admin };
    }
}
public class Appointment
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int DoctorId { get; set; }
    public int UserId { get; set; }
    public Doctor Doctor { get; set; }
    public User User { get; set; }
}

