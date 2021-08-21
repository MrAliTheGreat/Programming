package com.MrAli;

public class BankAccount {
    private String accountNumber;
    private double balance;
    private String customerName;
    private String email;
    private String phoneNumber;

    public BankAccount(){
        this("1234",0.0,"admin","admin's email","admin's phone number");
        System.out.println("You have choosen the default account!");
    }

    public BankAccount(String accountNumber , double balance, String customerName , String email , String phoneNumber){
        this.accountNumber=accountNumber;
        this.balance=balance;
        this.customerName=customerName;
        this.email=email;
        this.phoneNumber=phoneNumber;
    }


    public void deposit(double depositMoney){
        balance=balance+depositMoney;
        System.out.println("Successful deposit of " + depositMoney + "$");
    }
    public void withDraw(double withdrawMoney){
        if (withdrawMoney>balance){
            System.out.println("You don't have enough money to withdraw " + withdrawMoney + "$ from your account!");
            System.out.println("Your balance is " + balance + "$");
        }else{
            balance=balance-withdrawMoney;
            System.out.println("Successful Withdraw of " + withdrawMoney + "$");
        }
    }

    public String getAccountNumber() {
        return this.accountNumber;
    }

    public double getBalance() {
        return this.balance;
    }

    public String getCustomerName() {
        return this.customerName;
    }

    public String getEmail() {
        return this.email;
    }

    public String getPhoneNumber() {
        return this.phoneNumber;
    }
}
