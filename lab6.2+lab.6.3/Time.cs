
internal class Time
{
    private byte hours;
    private byte minutes;

    public Time()
    {
        hours = 0;
        minutes = 0;
    }
    public Time(byte hours, byte minutes)
    {
        this.hours = hours;
        if (minutes < 60)
        {
            this.minutes = minutes;
        }
        else
        {
            this.minutes = 0;
        }
    }

    public byte Hours
    {
        get
        {
            return hours;
        }
        set
        {
            this.hours = value;
        }
    }
    public byte Minutes
    {
        get
        {
            return minutes;
        }
        set
        {
            if (value<60)
            this.minutes = value;
            else
                this.minutes = 0;
        }
    }

    public static Time operator +(Time t, uint addMin)
    {
        uint totalMinutes = (uint)(t.hours * 60 
            + t.minutes + addMin);
        uint newMinutes = totalMinutes % 60;
        uint newHours = (totalMinutes / 60);

        return new Time((byte)newHours, (byte)newMinutes);
    }

    public static Time operator +(uint addMin, Time t)
    {
        uint totalMinutes = (uint)(t.hours * 60 
            + t.minutes + addMin);
        uint newMinutes = totalMinutes % 60;
        uint newHours = (totalMinutes / 60);

        return new Time((byte)newHours, (byte)newMinutes);
    }

    public static Time operator ++(Time t)
    {
        if (t.minutes == 59)
            return new Time((byte)(t.hours+1), 0);
        else return new Time (t.hours,t.minutes);
    }

    public static Time operator --(Time t)
    {
        if (t.minutes == 0 && t.hours != 0)
        {
            return new Time((byte)(t.hours - 1), 59);
        }
        else
        {
            if (t.minutes == 0 && t.hours == 0)
            {
                Console.WriteLine("Ошибка, отрицательное время!");
                return new Time(0, 0);
            }
            else
            {
                return new Time(t.hours, t.minutes);
            }
        }
    }

    // Явное преобразование типа Time в тип byte
    public static explicit operator byte(Time t)
    {
        return t.hours;
    }

    // Неявное преобразование типа Time в тип bool 
    public static implicit operator bool(Time t)
    {
        return t.hours != 0 || t.minutes != 0;
    }

    public static Time operator -(uint subMin, Time t)
    {
        uint totalMinutes = (uint)(t.hours * 60
            + t.minutes - subMin);
        if (totalMinutes > subMin)
        {
            uint newMinutes = totalMinutes % 60;
            uint newHours = (totalMinutes / 60);
            return new Time((byte)newHours, (byte)newMinutes);
        }
        else
        {
            Console.WriteLine("Количество вычитаемых" +
                " минус превышает общее время");
            return new Time(0, 0);
        }
    }

    public static Time operator -(Time t, uint subMin)
    {
        uint totalMinutes = (uint)(t.hours * 60 + t.minutes - subMin);
        if (totalMinutes > subMin)
        {
            uint newMinutes = totalMinutes % 60;
            uint newHours = (totalMinutes / 60);
            return new Time((byte)newHours, (byte)newMinutes);
        }
        else
        {
            Console.WriteLine("Количество вычитаемых " +
                "минус превышает общее время");
            return new Time(0, 0);
        }
    }
    public override string ToString()
    {
        return $"{hours:D2}:{minutes:D2}";
    }
}