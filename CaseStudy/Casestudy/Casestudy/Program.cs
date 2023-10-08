using System;
using casestudy1;
using caseStudy2;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AppEngine engine = new AppEngine();
            UserInterface userInterface = new ConsoleUserInterface(engine);
            userInterface.Run();
        }
    }
}
