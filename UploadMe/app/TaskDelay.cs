using System;
using System.Xml.XPath;

namespace app
{
    class TaskDelay{
        public static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            program.result = "Hello World test";
            return "Something";
        }
    }
}