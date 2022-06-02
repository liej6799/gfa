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

    public void setStartCalendar(long millis) {
        this.startCalendar = new DateTime().withMillis(millis);
    }

    public DateTime getEndCalendar() {
        return endCalendar;
    }

    public void setEndCalendar(long millis) {
        this.endCalendar = new DateTime().withMillis(millis);
    }


    public void setNextDay() {
        if (this.startCalendar.plusDays(1).isBeforeNow())
        {
            this.startCalendar =  this.startCalendar.plusDays(1);
            this.endCalendar =  this.endCalendar.plusDays(1);
        }

    }
    public void setPrevDay() {
        this.startCalendar =  this.startCalendar.minusDays(1);
        this.endCalendar =  this.endCalendar.minusDays(1);
    }


}
