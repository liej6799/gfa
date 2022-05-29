package com.example.gfamobile.data.model;

import org.joda.time.DateTime;

import java.util.Calendar;

public class Date {
    private DateTime startCalendar;
    private DateTime endCalendar;

    public Date() {
        this.startCalendar = new DateTime();
        this.endCalendar = new DateTime();
    }

    public DateTime getStartCalendar() {
        return startCalendar;
    }

    public void setStartCalendar(int year, int month, int day) {
        this.startCalendar = new DateTime(year, month, day, 0, 0);
    }

    public DateTime getEndCalendar() {
        return endCalendar;
    }

    public void setEndCalendar(int year, int month, int day) {
        this.endCalendar = new DateTime(year, month, day, 0, 0);
    }
}
