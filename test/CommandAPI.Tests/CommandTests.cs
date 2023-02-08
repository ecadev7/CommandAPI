using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                HowTo = "do something",
                Platform = "some platform",
                CommandLine = "some commandline"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            // arrange
            var testCommand = new Command
            {
                HowTo = "do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };

            // act
            testCommand.HowTo = "execute unit tests";

            // assert
            Assert.Equal("execute unit tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            // Given
            var testCommand = new Command
            {
                HowTo = "do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet tests"
            };

            // When
            testCommand.Platform = "xUnit new";

            // Then
            Assert.Equal("xUnit new", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            var testCommand = new Command
            {
                HowTo = "do something awesome",
                Platform = "xUnit",
                CommandLine = "dotnet tests"
            };

            testCommand.CommandLine = "dotnet tests new";

            Assert.Equal("dotnet tests new", testCommand.CommandLine);
        }
    }
}