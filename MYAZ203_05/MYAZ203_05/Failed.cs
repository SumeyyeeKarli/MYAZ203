﻿public class Failed : Result
{
    public Failed() : base(false, "Failed!")
    {

    }
    public Failed(string message) : base(false, message)
    {

    }

}
