# C#

**BankAccount Exercise**
Create a BankAccount class with accountNumber and balance attributes.
The attributes should be private, and public methods should be provided to deposit and withdraw money, as well as to get the current balance. Add a method to transfer money between two accounts.

**Authorship Exercise**
Create Author and Book classes with properties, extend them, link them via an Authorship class, and implement methods in Authorship to display details and add contribution information.

**HealthClinic Medical Information System**

*Description:*
"HealthClinic" is a medical information system designed for clinics to manage medical data and ensure quality patient care. The system is multi-tenant, allowing different clinics to use it for their needs.

*Technologies Used:*
Programming Language: C#
Framework: ASP.NET Core
Database: SQL Server
Object-Relational Mapping (ORM): Entity Framework Core
Multi-Tenant Library: SaasKit
Authentication and Authorization: ASP.NET Identity
Front-End Framework: Bootstrap
Version Control: Git

*Functionality by Roles:*
- Patient:
  - Registration in the system and creation of a personal account.
  - Viewing personal medical history, and prescribed medications.
  - Appointment scheduling with doctors through the personal account.
  - Receipt of notifications about upcoming appointments.
- Doctor:
  - Viewing appointment schedules and patient records(medical history, prescribed medications).
  - Adding new records of appointments.
  - Updating patient records.
  - Managing the own profile.
- Administrator:
  - User management (creating, editing, deleting user accounts).
  - Setting up schedules for doctors.
  - Generating reports on clinic operations and patient database.

*Admin Panel Pages* contains 
- list of users with the ability to create/edit/delete users with different roles
- list of appointments between a doctor and a patient with the ability to schedule/reschedule/delete an appointment

*Patient Page* - main page where a patient can 
- click on edit his profile - The user edit page will be opened
- check the scheduled appointments
book an appointment ->
the page with the list of doctors will be opened ->
if click on check an availability -> page with available slots will appear with the ability to book the date and time.

