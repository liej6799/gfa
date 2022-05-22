package com.example.gfamobile.data.model;

public class Sale {

    private int Total;
    private String DateSale;
    private String TimeSale;
    private boolean Expanded;

    public Sale(int total, String dateSale, String timeSale) {
        Total = total;
        DateSale = dateSale;
        TimeSale = timeSale;
        Expanded = false;
    }

    public int getTotal() {
        return Total;
    }

    public void setTotal(int total) {
        Total = total;
    }

    public String getDateSale() {
        return DateSale;
    }

    public void setDateSale(String dateSale) {
        DateSale = dateSale;
    }

    public String getTimeSale() {
        return TimeSale;
    }

    public void setTimeSale(String timeSale) {
        TimeSale = timeSale;
    }

    public boolean isExpanded() {
        return Expanded;
    }

    public void setExpanded(boolean expanded) {
        Expanded = expanded;
    }
}
