package com.example.gfamobile.util;

import java.text.NumberFormat;
import java.util.Currency;

public class Helper {

    public static NumberFormat GetCurrencyHelper()
    {
        NumberFormat format = NumberFormat.getCurrencyInstance();
        format.setMaximumFractionDigits(0);
        format.setCurrency(Currency.getInstance("IDR"));
        return format;
    }
}
