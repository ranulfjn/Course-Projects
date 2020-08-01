
public class healthyBurger extends Hamburger {
    
   public healthyBurger(String bread,String meat,double price) 
    {
        super(bread,meat,price);
    }

    @Override
    public double addOn(boolean lettuce, boolean tomato, boolean onion,
                            boolean cheese, boolean olives, boolean egg) {
    
        
            System.out.println("Healthy " + bread + " burger with "+ meat +" meat :"+ price);
        


        if (lettuce) {
            price += .25;
            System.out.println("Lettuce: .25");
        } else {
            System.out.println("");
        }

        if (tomato) {
            price += .35;
            System.out.println("Tomato: .35");
        } else {
            System.out.println("");
        }

        if (onion) {
            price += .20;
            System.out.println("Onion: .20");
        } else {
            System.out.println("");
        }

        if (cheese) {
            price += .75;
            System.out.println("Cheese: .75");
        } else {
            System.out.println("");
        }

        if (olives) {
            price += .90;
            System.out.println("Kale: .90");
        } else {
            System.out.println("");
        }

        if (egg) {
            price += .65;
            System.out.println("Mushroom: .65");
        } else {
            System.out.println("");
        }

        System.out.println("Total: " + price);
        return price;
    }
    
}
