namespace HealthClinic;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("Nadiia", "Klichko", "nad.klicko@gmail.com")
        Role admin = new Role("admin");
        Role doctor = new Role("doctor");
        Role user = new Role("user");

        UserManager userManager = new UserManager();
        userManager.addUser(user1);
        userManager.addRole(admin);
        userManager.addRole(doctor);
        userManager.addRole(user);

        userManager.assignRole(user1, admin);


    }
}

class User{
    private string firstName;
    private string lastName;
    private string email;
    private string address;
    private string phoneNumber;
    private Role role;

    public User(string firstName, string lastName, string email){
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
    }

    public string getFirstName(){
        return this.firstName;
    }

    public void assignRole(Role role){
        this.role = role;
    }
}

class Role{
    private string name;

    public Role(string name){
        this.name = name;
    }
}

class UserManager{
    private User[] users;
    private Role[] roles;
    private userCounter;
    private roleCounter;

    public UserManager(){
        this.users = new User[100];
        this.roles = new Role[4];
        this.userCounter = 0;
        this.roleCounter = 0;
    }

    public void addUser(User user){
        users[userCounter] = user;
        userCounter++;
    }

    public void addRole(Role role){
        roles[roleCounter] = role;
        roleCounter++;
    }

    public void assignRoleToUser(User user, Role role){
        // if users and roles contains user and role 
        user.assignRole();
    }

    public getUsers(){
        for (int i = 0; i < userCounter, i++){
            Console.WriteLine($"First name: {users[i].getFirstName()}");
        }
    }
}


