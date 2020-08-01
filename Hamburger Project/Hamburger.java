public class Hamburger 
{
    public String bread;
    public String meat;
    public double price;

    public Hamburger(String bread, String meat,double price) 
    {
       this.bread = bread;
       this.meat = meat;
       this.price=price;
    }



    public double addOn(boolean lettuce, boolean tomato, boolean onion,
                            boolean cheese, boolean opt5, boolean opt6) {
        
        
        System.out.println("Regular " + bread + " burger with "+ meat +" meat :"+ price);


        if (lettuce) {
            price += .25;
            System.out.println("Added Lettuce Extra: .25");
        } 
        

        if (tomato) {
            price += .35;
            System.out.println("Added Tomato Extra : .35");
        } 

        if (onion) {
            price += .20;
            System.out.println("Added Onion Extra: .20");
        } 

        if (cheese) {
            price += .75;
            System.out.println("Added Cheese Extra: .75");
        } 


        System.out.println("Total: " + price);
        return price;
    }
}
