using System;
using System.Diagnostics; //add this library to use "Process" class
using System.Threading;

class ProcessStart
{
    static void Main(string[] args)
    {
        //I.How to start external program from our program?
        var osType = Environment.OSVersion.ToString().ToLower();
        var slashOS = string.Empty;

        if (osType.IndexOf("windows") != -1)
        {  //windows use backslash
            slashOS = @"\";
        }
        else if (osType.IndexOf("unix") != -1)
        {  //Linux(Unix) use slash
            slashOS = "/";
        }
        else
        {
            throw new Exception("OS was not detected correctly!");
        }

        string relativePath = ".." + slashOS + ".." + slashOS + ".." 
                                   + slashOS + "DateTime" + slashOS + "bin" + slashOS + "Debug";
        //NOTE: on Win machine this mean: @"..\..\..\DateTime\bin\Debug"

        //////////////////////////////////////////////////////////////////////////////
        Process program = new Process();
        program.StartInfo.WorkingDirectory = relativePath;
        program.StartInfo.FileName = "DateTime.exe";
        program.Start();

        try
        {
            Console.WriteLine("Is program respond normally? = " + program.Responding);
            program.WaitForExit(1000 * 60 * 1);    //Wait for 1 minute to exit (alternatively wait for 5 minutes: (1000 * 60 * 5)). 
            Console.WriteLine("Is program exited normally? =  " + program.HasExited);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error, the program has exited or not responding !!! {0}", ex.StackTrace);
            Thread.Sleep(1000 * 60 * 1);
        }
        //////////////////////////////////////////////////////////////////////////////
    }
}

//Process.WaitForExit Method() and more..
//https://msdn.microsoft.com/en-us/library/fb4aw7b8(v=vs.110).aspx
//https://msdn.microsoft.com/en-us/library/system.diagnostics.process.exited(v=vs.110).aspx
//WARNING: WaitForExit() method do NOT work in "Mono" for now !!!