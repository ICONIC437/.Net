using System;

public class Patient
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; } // in KG
    public double Height { get; set; } // in Centimeters

    // Custom Constructor
    public Patient(string firstName, string lastName, double weight, double height)
    {
        FirstName = firstName;
        LastName = lastName;
        Weight = weight;
        Height = height;
    }

    // Method to calculate blood pressure
    public string CalculateBloodPressure(int systolic, int diastolic)
    {
        if (systolic >= 180 || diastolic >= 120)
            return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
        else if (systolic >= 140 || diastolic >= 90)
            return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
        else if (systolic >= 130 || diastolic >= 80)
            return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
        else if (systolic >= 120 || diastolic >= 80)
            return "ELEVATED";
        else
            return "NORMAL";
    }

    // Method to calculate BMI
    public double CalculateBMI()
    {
        // Convert height from centimeters to meters
        double heightInMeters = Height / 100.0;

        // Calculate BMI using the formula: BMI = kg/m^2
        double bmi = Weight / (heightInMeters * heightInMeters);

        return bmi;
    }

    // Method to print patient information
    public void PrintInformation()
    {
        Console.WriteLine("Patient Information:");
        Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        Console.WriteLine("Weight: " + Weight + " KG");
        Console.WriteLine("Height: " + Height + " Centimeters");

        // Calculate blood pressure
        int systolic = 120; // Example value, you can customize it
        int diastolic = 80; // Example value, you can customize it
        string bloodPressure = CalculateBloodPressure(systolic, diastolic);
        Console.WriteLine("Blood Pressure: " + bloodPressure);

        // Calculate BMI
        double bmi = CalculateBMI();
        Console.WriteLine("BMI: " + bmi.ToString("0.00"));

        // Determine BMI status
        string bmiStatus;
        if (bmi >= 25.0)
            bmiStatus = "Overweight";
        else if (bmi >= 18.5 && bmi <= 24.9)
            bmiStatus = "Normal (In the healthy range)";
        else
            bmiStatus = "Underweight";
        Console.WriteLine("BMI Status: " + bmiStatus);
    }
}
