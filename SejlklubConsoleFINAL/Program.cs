
using SejlklubLibraryFINAL;

#region Member 
// Create repository 
MemberRepository repository = new MemberRepository();

Console.WriteLine("\n--- Create new members ---");
Member member1 = new Member("John Østergård", "john.østerg@gmail.com", 21, "123john123", 70150909);
Member member2 = new Member("Anna Sørensen", "anna.sørensen@gmail.com", 22, "123anna123", 70150910);

Console.WriteLine(member1);
Console.WriteLine(member2);

// Add members to the member list
repository.Add(member1);
repository.Add(member2);

// Delete members from the member list
Console.WriteLine("\n--- Deleting member ---");
Console.WriteLine("Deleting member with ID 21");
bool deleted = repository.Delete(21);
Console.WriteLine(deleted ? "Member deleted successfully." : "Member not found.");
Console.WriteLine();

// Update member information
Console.WriteLine("\n--- Update member ---");
Console.WriteLine("Updating member with ID 22...");
Member updatedMember = new Member("Jane Updated", "updated@mail.com", 22, /*same ID*/ "newpass", 88888888); 
repository.Update(updatedMember);
Console.WriteLine(repository.GetById(22));

// Search for members by name
Console.WriteLine("\n--- Search for member by name ---");
Console.WriteLine("Search by name (Jane):");
List<Member> foundByName = repository.SearchByName("Jane");
foreach (Member member in foundByName)
{
    Console.WriteLine(member);
}

// Search for member by ID. 
Console.WriteLine("\n--- Search member by ID ---");
Console.WriteLine("Search by ID (21):");
Member foundById = repository.GetById(21);
Console.WriteLine(foundById);

// Show all members
Console.WriteLine("\n--- Show all members ---");
Console.WriteLine("All members:");
List<Member> allMembers = repository.GetAll();
foreach (Member member in allMembers)
{
    Console.WriteLine(member);
}
#endregion

#region Boat and MaintenanceLog
// Repository
BoatRepository boatRepository = new BoatRepository();

// Create boats
Console.WriteLine("\n--- Create new boat ---");
Boat boat1 = new Boat("Motorboat", "Yamaha 300", "Yamaha Engine", 5.5, 2.0, 1.2, 2015, "Sea Queen", "B001", Guid.NewGuid());
Boat boat2 = new Boat("Sailboat", "Beneteau", "None", 8.0, 2.5, 1.5, 2010, "Wind Rider", "B002", Guid.NewGuid());

Console.WriteLine(boat1);
Console.WriteLine();
Console.WriteLine(boat2);

// Add boats to repository
boatRepository.AddBoat(boat1);
boatRepository.AddBoat(boat2);

// Create maintenance logs
MaintenanceLog log1 = new MaintenanceLog(DateTime.Now, Guid.NewGuid());
MaintenanceLog log2 = new MaintenanceLog(DateTime.Now, Guid.NewGuid());

log1.ReportIssue("Engine making strange noise", boat1);
log2.ReportIssue("Small leak near the hull", boat2);

// Put logs in a list
List<MaintenanceLog> logs = new List<MaintenanceLog>();
logs.Add(log1);
logs.Add(log2);

// Show all boats and their maintenance logs
Console.WriteLine("\n--- Show all Boats ---");
foreach (Boat boat in boatRepository.GetAllBoats())
{
    Console.WriteLine(boat);
    Console.WriteLine();
}

Console.WriteLine("\n--- Maintenance Logs ---");
foreach (MaintenanceLog log in logs)
{
    Console.WriteLine(log.ReadLog());
    Console.WriteLine();
}

// Report maintenance issues
// (simuleret her som demo)
Console.WriteLine("\n--- Reporting new issue ---");
MaintenanceLog newLog = new MaintenanceLog(DateTime.Now, Guid.NewGuid());
newLog.ReportIssue("Broken navigation light", boat1);
Console.WriteLine(newLog.ReadLog());

Console.ReadKey();
#endregion

#region News
// Create news articles
News newsPost = new News
(   "Julefrokost i klubben", 
    new DateOnly(2025, 12, 25), 
    new TimeOnly(12, 0), 
    "Vi har afholdt julefrokost i klubben!", 
    Guid.NewGuid()
);


// Show all news articles
List<News> newsPosts = new List<News> { newsPost };
foreach (var post in newsPosts)
{
    Console.WriteLine($"Title: {post.Title}");
    Console.WriteLine($"Content: {post.Description}");
    Console.WriteLine($"Date: {post.Date}");
    Console.WriteLine($"Id: {post.Id}");
    Console.WriteLine();
}

// Update news articles
newsPosts[0].UpdateDescription("Vi havde en fantastisk julefrokost i klubben!");

// Delete news articles
newsPosts.Remove(newsPosts[0]);

#endregion

#region Events

// Create one event
Event newYearEvent = new Event(
    "NytårsKur i klubben",
    new DateOnly(2026, 1, 16),
    new TimeOnly(18, 0),
    "Der afholdes NytårsKur i klubben",
    "Community Center",
    Guid.NewGuid()
);

// Show all events
List<Event> allEvents = new List<Event>();

// Update event location
newYearEvent.UpdateLocation("Main Hall");

// Delete event
allEvents.Remove(newYearEvent);

// Sign up members for event
newYearEvent.AddMember("member1@example.com");


#endregion

#region Booking

// Create booking
Booking booking = new Booking(
    "2025-07-15",
    "10:00",
    "Island",
    500.0,
    true
);

// Show all bookings
List<Booking> bookings = new List<Booking> { booking };

// Active bookings – fx alle der er Booked = true
List<Booking> activeBookings = bookings.Where(b => b.Booked).ToList();

// End booking 
booking.EndOfBooking();

// Edit booking destination
booking.Destination = "New Island";


#endregion


#region Statistics

#endregion




