namespace hospital;
public class Patient
{
         private int Pid;
         private String Pname;
         private int Pbedtype;
         private int Pnod;

         public Patient(int id, String name, int bed, int days)
         {

                  Pid = id;
                  Pname = name;
                  Pbedtype = bed;
                  Pnod = days;
         }

         public int getPatientid()
         {
                  return Pid;
         }

         public String getPatientName()
         {
                  return Pname;
         }

         public int getBedtype()
         {
                  return Pbedtype;
         }

         public int getNod()
         {
                  return Pnod;
         }

         public void setPatientid(int a)
         {
                  Pid = a;
         }

         public void setPatientName(String b)
         {
                  Pname = b;
         }

         public void setBedtype(int c)
         {
                  Pbedtype = c;
         }

         public void setNod(int d)
         {
                  Pnod = d;
         }


         private int getPricePerDay()
         {
                  int price = 0;
                  switch (Pbedtype)
                  {

                           case 1:
                                    price = 500;
                                    break;

                           case 2:
                                    price = 350;
                                    break;


                           case 3:
                                    price = 200;
                                    break;

                           default:
                                    price = 100;
                                    break;
                  }
                  return price;
         }


         public double getBillAmount()
         {
                  double amount;
                  amount = Pnod * getPricePerDay();
                  return amount;
         }
}
