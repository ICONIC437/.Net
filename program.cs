public class Program
{
    static void Main()
    {
        // Step 1: Ask the user to enter their age
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());

        // Step 2: Ask the user to insert the needed patient information
        Console.WriteLine("Enter patient information:");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Weight (in KG): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Height (in Centimeters): ");
        double height = double.Parse(Console.ReadLine());

        // Step 3: Create/instantiate a Patient object with the provided information
        Patient patient = new Patient(firstName, lastName, weight, height);

        // Call the method for printing the patient information
        patient.PrintInformation();
    }
}
