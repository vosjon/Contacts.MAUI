namespace Contacts.MAUI.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		List<Contact> contacts = new List<Contact>()
		{
			new Contact() {Name="John Doe", Email="JohnDoe@gmail.com"},
            new Contact() {Name="Jane Doe", Email="JaneDoe@gmail.com"},
            new Contact() {Name="Tom Hanks", Email="TomHanks@gmail.com"},
            new Contact() {Name="Frank Liu", Email="frankliu@gmail.com"},
        };

		listContacts.ItemsSource = contacts;
	}

	public class Contact
	{
        public string Name { get; set; }
        public string Email { get; set; }
    }
}