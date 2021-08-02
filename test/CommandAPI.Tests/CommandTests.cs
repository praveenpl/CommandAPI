using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some platform",
                CommandLine = "Some commandline"
            }; 
        }

        

        [Fact]
        public void CanChangeHowTo()
        {

            testCommand.HowTo = "Execute Unit Tests";

            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            testCommand.Platform = "XUnit1";

            Assert.Equal("XUnit1", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            testCommand.CommandLine = "dotnet test1";

            Assert.Equal("dotnet test1", testCommand.CommandLine);
        }

        public void Dispose()
        {
            testCommand = null;
        }
    }
}