package com.example.gfamobile.data.model;

public class SaleItem {
    private int Quantity;
    private String Name;
    private int Price;
    private int Total;

    public SaleItem(int quantity, String name, int price, int total) {
        Quantity = quantity;
        Name = name;
        Price = price;
        Total = total;
    }

    public int getQuantity() {
        return Quantity;
    }

    public void setQuantity(int quantity) {
        Quantity = quantity;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public int getPrice() {
        return Price;
    }

    public void setPrice(int price) {
        Price = price;
    }

    public int getTotal() {
        return Total;
    }

    public void setTotal(int total) {
        Total = total;
    }
}
