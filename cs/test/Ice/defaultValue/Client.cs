// **********************************************************************
//
// Copyright (c) 2003-2010 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************

using System;
using System.Diagnostics;
using System.Reflection;

[assembly: CLSCompliant(true)]

[assembly: AssemblyTitle("IceTest")]
[assembly: AssemblyDescription("Ice test")]
[assembly: AssemblyCompany("ZeroC, Inc.")]

public class Client
{
    private static int run(string[] args)
    {
        AllTests.allTests();

        return 0;
    }

    public static void Main(string[] args)
    {
        int status = 0;

        Debug.Listeners.Add(new ConsoleTraceListener());

        try
        {
            status = run(args);
        }
        catch(System.Exception ex)
        {
            Console.Error.WriteLine(ex);
            status = 1;
        }

        if(status != 0)
        {
            System.Environment.Exit(status);
        }
    }
}
