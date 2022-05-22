package com.example.gfamobile.data.model;

import org.joda.time.DateTime;

public class Sale {

    private Double Total;
    private DateTime DateSale;
    private boolean Expanded;

    public Sale(Double total, DateTime dateSale) {
        Total = total;
        DateSale = dateSale;
        Expanded = false;
    }

    public Double getTotal() {
        return Total;
    }

    public void setTotal(Double total) {
        Total = total;
    }

    public DateTime getDateSale() {
        return DateSale;
    }

    public void setDateSale(DateTime dateSale) {
        DateSale = dateSale;
    }


    public boolean isExpanded() {
        return Expanded;
    }

    public void setExpanded(boolean expanded) {
        Expanded = expanded;
    }
}
