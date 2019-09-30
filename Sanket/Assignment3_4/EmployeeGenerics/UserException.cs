using System;

public class UserException : Exception
{
    //public String Excpmessage;
	public UserException(String message) : base(message)
	{
        //Console.WriteLine(message); 
    }
}
