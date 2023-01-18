namespace hospital;

public class InHousePatient : Patient{

        private float discount;

        public float getDiscount(){
        return discount;
        }

        public void setDiscount(float _discount){
            discount = _discount;
        }

        public InHousePatient(int id, String s, int bed, int days, float dis):base(id,s,bed,days)
        {
        
        discount = dis;
        }

        public new double  getBillAmount(){
        double amount = base.getBillAmount();
        amount = amount - amount * discount/100;
        return amount;
        }
}