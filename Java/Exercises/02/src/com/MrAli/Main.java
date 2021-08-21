package com.MrAli;

class Car{
    private boolean engine;
    private int wheels;
    private int cylinders;
    private String name;

    public Car(int cylinders, String name) {
        this.engine = true;
        this.wheels = 4;
        this.cylinders = cylinders;
        this.name = name;
    }

    public int getCylinders() {
        return cylinders;
    }

    public String getName() {
        return name;
    }

    public String startEngine(){
        return "You have turned on the engine!";
    }

    public String accelerate(){
        return "Your speed has increased!";
    }

    public String brake(){
        return "You're using the brakes of the car!";
    }
}

class Benz extends Car{
    public Benz(int cylinders, String name) {
        super(cylinders, name);
    }

    @Override
    public String startEngine() {
        return "Welcome back to your Benz";
    }

    @Override
    public String accelerate() {
        return "Benz is accelerating";
    }

    @Override
    public String brake() {
        return "Benz is Stopping";
    }
}

class Ferrari extends Car{
    public Ferrari(int cylinders, String name) {
        super(cylinders, name);
    }

    @Override
    public String startEngine() {
        return "Ferrari from Italy!";
    }

    @Override
    public String accelerate() {
        return "Accelerating Ferrari!";
    }

    @Override
    public String brake() {
        return "Ferrari Brakes!";
    }
}

class Suzuki extends Car{
    public Suzuki(int cylinders, String name) {
        super(cylinders, name);
    }
}


public class Main {

    public static void main(String[] args) {
        String name="Suzuki";
        if (name=="Ferrari"){
            Car car=new Ferrari(12,"SLS");
            System.out.println("You have chosen Ferrari!");
            System.out.println(car.accelerate());
            System.out.println(car.brake());
            System.out.println(car.startEngine());
        }else if (name=="Benz"){
            Car car=new Benz(18,"458");
            System.out.println("You have chosen Benz");
            System.out.println(car.accelerate());
            System.out.println(car.brake());
            System.out.println(car.startEngine());
        }else if (name=="Suzuki"){
            Car car=new Suzuki(8,"Grand Richardo");
            System.out.println("You have chosen Suzuki");
            System.out.println(car.accelerate());
            System.out.println(car.brake());
            System.out.println(car.startEngine());
        }
    }
}
