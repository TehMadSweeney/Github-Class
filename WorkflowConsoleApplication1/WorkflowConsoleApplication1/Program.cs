﻿using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace WorkflowConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test
            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);
        }
    }
}
