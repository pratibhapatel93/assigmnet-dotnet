namespace hospital;
using System;
class Program
{
         public static void displayPatient(Patient p)
         {
                  Console.WriteLine("**************************************");
                  Console.WriteLine($"PatientId     : {p.getPatientid()}");
                  Console.WriteLine($"Patient Name  :  {p.getPatientName()}");
                  Console.WriteLine($"Bed type      :  {p.getBedtype()}");
                  Console.WriteLine($"No Of Days    :  {p.getNod()}");
                  Console.WriteLine("**************************************");
                  Console.WriteLine($"Total Bill    :  {p.getBillAmount()}");
                  Console.WriteLine("**************************************");
               

         }

         public static void Main(string[] args)
         {
                  Patient p1 = new Patient(101, "Seema", 1, 10);
                  InHousePatient p2 = new InHousePatient(102, "Pritam", 1, 10, 20);

                  displayPatient(p1);
                  displayPatient(p2);
         }

}