package com.example.gfamobile.data.model;

import java.util.Calendar;

public class Date {
    private int startDayOfMonth;
    private int startMonth;
    private int startYear;

    private int endDayOfMonth;
    private int endMonth;
    private int endYear;

    public Date() {

        this.startDayOfMonth = Calendar.getInstance().get(Calendar.DAY_OF_MONTH);
        this.startMonth = Calendar.getInstance().get(Calendar.MONTH) + 1; // Month start with 0
        this.startYear = Calendar.getInstance().get(Calendar.YEAR);
        this.endDayOfMonth = Calendar.getInstance().get(Calendar.DAY_OF_MONTH);
        this.endMonth = Calendar.getInstance().get(Calendar.MONTH) + 1; // Month start with 0
        this.endYear = Calendar.getInstance().get(Calendar.YEAR);
    }

    public int getStartDayOfMonth() {
        return startDayOfMonth;
    }

    public void setStartDayOfMonth(int startDayOfMonth) {
        this.startDayOfMonth = startDayOfMonth;
    }

    public int getStartMonth() {
        return startMonth;
    }

    public void setStartMonth(int startMonth) {
        this.startMonth = startMonth;
    }

    public int getStartYear() {
        return startYear;
    }

    public void setStartYear(int startYear) {
        this.startYear = startYear;
    }

    public int getEndDayOfMonth() {
        return endDayOfMonth;
    }

    public void setEndDayOfMonth(int endDayOfMonth) {
        this.endDayOfMonth = endDayOfMonth;
    }

    public int getEndMonth() {
        return endMonth;
    }

    public void setEndMonth(int endMonth) {
        this.endMonth = endMonth;
    }

    public int getEndYear() {
        return endYear;
    }

    public void setEndYear(int endYear) {
        this.endYear = endYear;
    }
}
