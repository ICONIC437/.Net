using System;

public class Patient
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; } // in KG
    public double Height { get; set; } // in Centimeters

    public Patient(string firstName, string lastName, double weight, double height)
    {
        FirstName = firstName;
        LastName = lastName;
        Weight = weight;
        Height = height;
    }

    public string CalculateBloodPressure(int systolic, int diastolic)
    {
        if (systolic >= 180 || diastolic >= 120)
        {
            return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
        }
        else if (systolic >= 140 || diastolic >= 90)
        {
            return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
        }
        else if (systolic >= 130 || diastolic >= 80)
        {
            return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
        }
        else if (systolic >= 120 || diastolic >= 80)
        {
            return "ELEVATED";
        }
        else if (systolic >= 90 || diastolic >= 60)
        {
            return "NORMAL";
        }
        else
        {
            return "Warning: Blood pressure values are not in the range.";
        }
    }

    public double CalculateBMI()
    {
        double heightInMeter = Height / 100; // convert centimeters to meters
        return Weight / (heightInMeter * heightInMeter);
    }

    public void PrintPatientInformation()
    {
        Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        Console.WriteLine("Weight: " + Weight + " KG");
        Console.WriteLine("Height: " + Height + " CM");
        
        int systolic = 120;
        int diastolic = 80;
        string bloodPressureResult = CalculateBloodPressure(systolic, diastolic);
        Console.WriteLine("Blood Pressure: " + bloodPressureResult);
        
        double bmi = CalculateBMI();
        Console.WriteLine("BMI: " + bmi);
        
        string bmiStatus = "";
        if (bmi >= 25.0)
        {
            bmiStatus = "Overweight";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            bmiStatus = "Normal (In the healthy range)";
        }
        else
        {
            bmiStatus = "Underweight";
        }
        Console.WriteLine("BMI Status: " + bmiStatus);
    }
}

public class Program
{
    public static void Main()
    {
        // Create a patient object and provide the required information
        Patient patient = new Patient("John", "Doe", 70, 180);

        // Print the patient information
        patient.PrintPatientInformation();
    }
}