
using SejlklubLibraryFINAL;

#region Member 
// Create repository 
MemberRepository repository = new MemberRepository();

// Create members 
Member member1 = new Member("John Østergård", "john.østerg@gmail.com", 21, "123john123", 70150909);
Member member2 = new Member("Anna Sørensen", "anna.sørensen@gmail.com", 22, "123anna123", 70150910);

Console.WriteLine(member1);

// Add members to the member list
repository.Add(member1);
repository.Add(member2);

// Delete members from the member list
Console.WriteLine("Deleting member with ID 21");
bool deleted = repository.Delete(21);
Console.WriteLine(deleted ? "Member deleted successfully." : "Member not found.");
Console.WriteLine();

// Update member information


// Search for members by name or ID

// Show all members

#endregion

#region Boat and MaintenanceLog
// Create boats

// Create maintenance logs

// Show all boats and their maintenance logs

// Report maintenance issues

#endregion


#region News
// Create news articles
// Show all news articles
// Update news articles
// Delete news articles

#endregion

#region Events
// Create events
// Show all events
// Update events
// Delete events
// Sign up members for events

#endregion


#region Booking
// Create bookings
// Show all bookings
// Active bookings
// End bookings
// Edit bookings


#endregion

#region Statistics

#endregion




