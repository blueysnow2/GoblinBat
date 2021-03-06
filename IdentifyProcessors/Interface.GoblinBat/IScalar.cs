﻿namespace ShareInvest.Interface.x64
{
    public interface IScalar
    {
        int[] Reaction
        {
            get;
        }
        int[] ShortMinutePeriod
        {
            get;
        }
        int[] ShortDayPeriod
        {
            get;
        }
        int[] LongMinutePeriod
        {
            get;
        }
        int[] LongDayPeriod
        {
            get;
        }
        int[] StopLoss
        {
            get;
        }
        int[] Revenue
        {
            get;
        }
    }
}