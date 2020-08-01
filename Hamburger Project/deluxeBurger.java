
public class deluxeBurger extends Hamburger {
   public deluxeBurger(String bread,String meat,double price) 
    {
        super(bread,meat,price);
    }

    @Override
    public double addOn(boolean chips, boolean drink, boolean cant,
                            boolean let_you, boolean do_that, boolean starfox) 
    {
        System.out.println("Deluxe Hamburger with " + bread +" bread" +" with "+meat+" meat: "+ price);
        if (chips) {
            price += 1.25;
            System.out.println("Added Chips Extra: 1.25");
        } 

        if (drink) {
            price += 2.35;
            System.out.println("Added Drink Extra: 2.35");
        } 
        
        System.out.println("Total: " + price);
        return price;
    }
    
}
