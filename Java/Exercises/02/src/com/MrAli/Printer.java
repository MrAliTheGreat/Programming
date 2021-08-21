package com.MrAli;

public class Printer {
    private int tonerLevel=100;
    private int printedPages=0;
    private boolean isDuplex;

    public Printer(int tonerLevel, boolean isDuplex) {
        if (tonerLevel<=100 && tonerLevel>=0){
            this.tonerLevel = tonerLevel;
        }else if(tonerLevel<0){
            this.tonerLevel=0;
            System.out.println("Toner level can't be a negative number so toner level is set to 0!");
        }else{
            System.out.println("Toner level can't be more than 100 so toner level is set to 100!");
        }
        this.isDuplex = isDuplex;
    }


    public void fillToner(int ink){
        this.tonerLevel+=ink;
        if (this.tonerLevel<0){
            this.tonerLevel=0;
            System.out.println("Toner level can't be a negative number so toner level is set to 0!");
        }else if (this.tonerLevel>100){
            this.tonerLevel=100;
            System.out.println("Toner level can't be more than 100 so toner level is set to 100!");
        }else {
            System.out.println("Toner Level is at " + this.tonerLevel + " now!");
        }
    }

    public void printing(int numberPages){
        this.printedPages+=numberPages;
        System.out.println("Printing " + numberPages + " Pages...");
        System.out.println("You have printed " + this.printedPages + " pages so far!");
        if (this.isDuplex==true){
            System.out.println("This printer is duplex by the way!");
        }
    }
}
