using System;

// ================= DELEGATE =================
public delegate double BillingStrategy(double amount);

// ================= EVENT =================
public delegate void HospitalNotification(string message);

// ================= ABSTRACT PATIENT =================
abstract class Patient
{
    public string Name;
    public int Age;

    public event HospitalNotification OnPatientAdmitted;

    public Patient(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Polymorphic method
    public abstract double CalculateBill(double baseAmount);

    public void AdmitPatient()
    {
        if (OnPatientAdmitted != null)
        {
            OnPatientAdmitted("Patient " + Name + " admitted.");
        }
    }
}

// ================= PATIENT TYPES =================
class GeneralPatient : Patient
{
    public GeneralPatient(string name, int age) : base(name, age) { }

    public override double CalculateBill(double baseAmount)
    {
        return baseAmount; // no extra charge
    }
}

class EmergencyPatient : Patient
{
    public EmergencyPatient(string name, int age) : base(name, age) { }

    public override double CalculateBill(double baseAmount)
    {
        return baseAmount + 2000; // emergency service charge
    }
}

class VIPPatient : Patient
{
    public VIPPatient(string name, int age) : base(name, age) { }

    public override double CalculateBill(double baseAmount)
    {
        return baseAmount + 3000; // VIP facilities
    }
}

// ===== New Patient Type: ConsultationPatient =====
class ConsultationPatient : Patient
{
    public ConsultationPatient(string name, int age) : base(name, age) { }

    public override double CalculateBill(double baseAmount)
    {
        return baseAmount + 500; // consultation fee
    }
}

// ================= HOSPITAL =================
class Hospital
{
    public void NotifyDoctor(string msg)
    {
        Console.WriteLine("Doctor Dept: " + msg);
    }

    public void NotifyBilling(string msg)
    {
        Console.WriteLine("Billing Dept: " + msg);
    }

    public void NotifyPharmacy(string msg)
    {
        Console.WriteLine("Pharmacy Dept: " + msg);
    }

    // Delegate-based billing strategy
    public double ApplyBilling(BillingStrategy strategy, double amount)
    {
        return strategy(amount);
    }
}

// ================= MAIN =================
class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();

        Console.WriteLine("=== Patient Management System ===");

        Console.Write("Enter Patient Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Base Treatment Cost: ");
        double baseCost = double.Parse(Console.ReadLine());

        Console.WriteLine("\nSelect Patient Type");
        Console.WriteLine("1. General");
        Console.WriteLine("2. Emergency");
        Console.WriteLine("3. VIP");
        Console.WriteLine("4. Consultation");
        Console.Write("Choice: ");
        int choice = int.Parse(Console.ReadLine());

        Patient patient;

        if (choice == 1)
            patient = new GeneralPatient(name, age);
        else if (choice == 2)
            patient = new EmergencyPatient(name, age);
        else if (choice == 3)
            patient = new VIPPatient(name, age);
        else
            patient = new ConsultationPatient(name, age); // new type

        // Subscribe events
        patient.OnPatientAdmitted += hospital.NotifyDoctor;
        patient.OnPatientAdmitted += hospital.NotifyBilling;
        patient.OnPatientAdmitted += hospital.NotifyPharmacy;

        // Step 1: Admit Patient (Event Triggered)
        patient.AdmitPatient();

        // Step 3: Calculate bill using polymorphism
        double calculatedAmount = patient.CalculateBill(baseCost);

        // Step 4: Dynamic billing strategy using delegate
        BillingStrategy gst = delegate (double amt)
        {
            return amt + (amt * 0.18); // 18% GST
        };

        double finalBill = hospital.ApplyBilling(gst, calculatedAmount);

        // Step 5: Generate Bill
        Console.WriteLine("\n===== BILL DETAILS =====");
        Console.WriteLine("Patient Name : " + patient.Name);
        Console.WriteLine("Patient Type : " + patient.GetType().Name);
        Console.WriteLine("Final Amount : ₹" + finalBill);
        Console.WriteLine("========================");

        Console.ReadLine();
    }
}


