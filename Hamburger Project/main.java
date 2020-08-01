
import java.util.Scanner;

public class main {

    public static void main(String[] args) {
        
        Scanner input =new Scanner(System.in);
        boolean option=true;
        while(option)
        {
            System.out.println("\t\t\t\tBurger Menu");
            System.out.println("_____________________________________________________________________");
            System.out.println("Enter 1 for regular Burger , 2 for healthy Burger, 3 for Delux Burger");
            int opt=input.nextInt();
            switch(opt)
            {
                case 1:Hamburger ham = new Hamburger("Rye","Pork",5.4);
                       System.out.println("Enter true to add Letuce else false");
                       boolean let=input.nextBoolean();
                       System.out.println("Enter true to add Tomatoes else false");
                       boolean tom=input.nextBoolean();
                       System.out.println("Enter true to add Onions else false");
                       boolean ono=input.nextBoolean();
                       System.out.println("Enter true to add cheese else false");
                       boolean che=input.nextBoolean();
                       ham.addOn(let,tom,ono,che,false,true);
                       System.out.println("\n");break;
                case 2:healthyBurger order = new healthyBurger("Wheat","Chicken",6.5);
                       System.out.println("Enter true to add Letuce else false");
                       boolean letu=input.nextBoolean();
                       System.out.println("Enter true to add Tomatoes else false");
                       boolean toma=input.nextBoolean();
                       System.out.println("Enter true to add Onions else false");
                       boolean onon=input.nextBoolean();
                       System.out.println("Enter true to add cheese else false");
                       boolean chee=input.nextBoolean();
                       System.out.println("Enter true to add olives else false");
                       boolean oli=input.nextBoolean();
                       System.out.println("Enter true to add eggs else false");
                       boolean egg=input.nextBoolean();
                       order.addOn(letu,toma,onon,chee,oli,egg);
                       System.out.println("\n"); break;
                case 3: deluxeBurger finalOrder = new deluxeBurger("Rich Grain","Beef",10);
                        
                       System.out.println("Enter true to add Chips else false");
                       boolean chips =input.nextBoolean();
                       System.out.println("Enter true to add Drink else false");
                       boolean drink =input.nextBoolean();
                       finalOrder.addOn(chips,drink,true,true,true,true);
                       break;
                default:System.out.println("Wrong Option!!!!");
            }
               System.out.println("Enter true to add more burgers and false to Exit"); 
                option=input.nextBoolean();
        }
    }
}