package com.example.gfamobile.data.model;

import org.joda.time.DateTime;
import org.joda.time.DateTimeZone;

import java.util.Calendar;

public class Date {
    private DateTime startCalendar;
    private DateTime endCalendar;

    public Date() {
        this.startCalendar = new DateTime(DateTimeZone.UTC);
        this.endCalendar = new DateTime(DateTimeZone.UTC);
    }

    public DateTime getStartCalendar() {
        return startCalendar;
    }

    public void setStartCalendar(int year, int month, int day) {
        this.startCalendar = new DateTime(year, month, day, 0, 0, 0, 0,  DateTimeZone.UTC);
    }

    public DateTime getEndCalendar() {
        return endCalendar;
    }

    public void setEndCalendar(int year, int month, int day) {
        this.endCalendar = new DateTime(year, month, day, 0, 0, 0, 0, DateTimeZone.UTC);
    }
}
