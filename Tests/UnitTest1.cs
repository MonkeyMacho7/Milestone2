using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace UVSim.Tests
{
    [TestClass]
    public class FileReadingTests
    {
        [TestMethod]
        public void TestReadFileSuccessfully()
        {

            string filePath = @"c:/temp/test1.txt";

            try
            {
                string content = File.ReadAllText(filePath);
                Assert.IsTrue(content.Length > 0, "File content should not be empty.");
            }
            catch (IOException ex)
            {
                Assert.Fail($"File read failed with error: {ex.Message}");
            }
        }
        [TestMethod]
        public void TestReadFileFail()
        {
            // Arrange
            string filePath = @"c:/temp/nonexistentfile.txt"; 

            // Act & Assert
            try
            {
                string content = File.ReadAllText(filePath);
                Assert.Fail("Expected an IOException due to a non-existent file, but no exception was thrown.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Expected failure: {ex.Message}");
                
                Assert.IsTrue(ex.Message.Contains("could not be found"), "The error message should state that the file could not be found.");
            }
        }
    }



    [TestClass]
    public class FileExistenceTests
    {
        [TestMethod]
        public void TestFileContent()
        {

            string filePath = "c:/temp/test1.txt"; // 


            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Assert.IsFalse(string.IsNullOrWhiteSpace(content), "File found but it is empty.");
            }
            else
            {
                Assert.Fail("File not found. Please provide a valid file path.");
            }
        }
    }



    [TestClass]
    public class ReadOperationTests
    {
        [TestMethod]
        public void TestReadWithValidInput()
        {
            // Arrange
            var originalInput = Console.In; 
            var simulatedInput = new StringReader("1234\n"); 
            Console.SetIn(simulatedInput);
            int memoryLocation = 10; 

            // Act
            Program.BasicML(0, 10, memoryLocation); 

            // Cleanup
            Console.SetIn(originalInput); 

            // Assert
            Assert.AreEqual(1234, Program.memory[memoryLocation], "The value 1234 should be stored at the specified memory location.");
        }
    }



    [TestClass]
    public class WriteOperationTests
    {
        [TestMethod]
        public void TestWriteOperation()
        {
            // Arrange
            var memoryLocation = 10; // Example memory location
            var expectedValue = 1234; // Expected value to be written
            Program.memory[memoryLocation] = expectedValue; // Set the memory location with expected value

            var originalOutput = Console.Out; // Preserve the original output stream
            using var writer = new StringWriter();
            Console.SetOut(writer); // Redirect console output to the StringWriter

            // Act
            Program.BasicML(0, 11, memoryLocation); // Execute WRITE operation

            // Cleanup
            Console.SetOut(originalOutput); // Restore original output stream

            // Assert
            var output = writer.ToString();
            Assert.IsTrue(output.Contains(expectedValue.ToString()), "The output should contain the value from the specified memory location.");
        }
    }


    [TestClass]
    public class LoadOperationTests
    {
        [TestMethod]
        public void TestLoadOperation()
        {
            // Arrange
            int memoryLocation = 10; // Example memory location
            int expectedValue = 1234; // Expected value to load
            Program.memory[memoryLocation] = expectedValue; // Set the memory location with expected value

            // Act
            Program.BasicML(0, 20, memoryLocation); // Execute LOAD operation

            // Assert
            Assert.AreEqual(expectedValue, Program.accumulator, "The accumulator should have the value from the specified memory location.");
        }
        [TestMethod]
        public void TestLoadOperation_InvalidMemoryLocation()
        {
            // Arrange
            int invalidMemoryLocation = 999; // Assuming this is out of range

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                Program.BasicML(0, 20, invalidMemoryLocation));
        }
    }

    [TestClass]
    public class StoreOperationTests
    {
        [TestMethod]
        public void TestStoreOperation()
        {
            // Arrange
            int memoryLocation = 10; // Example memory location
            int valueToStore = 1234; // Value to store in the accumulator
            Program.accumulator = valueToStore; // Set the accumulator with value to store

            // Act
            Program.BasicML(0, 21, memoryLocation); // Execute STORE operation (assuming the operation code for STORE is 21)

            // Assert
            Assert.AreEqual(valueToStore, Program.memory[memoryLocation], "The memory location should have the value from the accumulator.");
        }
        [TestMethod]
        public void TestStoreOperation_InvalidMemoryLocation()
        {
            // Arrange
            int invalidMemoryLocation = 999; // Assuming this is out of range
            Program.accumulator = 1234; // Any value for testing

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Program.BasicML(0, 21, invalidMemoryLocation));
        }
    }

    [TestClass]
    public class AddOperationTests
    {
        [TestMethod]
        public void TestAddOperation()
        {
            // Arrange
            int memoryLocation = 10; // Example memory location
            int valueInMemory = 200; // Value in the specified memory location
            Program.memory[memoryLocation] = valueInMemory;
            int initialValueInAccumulator = 100; // Initial value in the accumulator
            Program.accumulator = initialValueInAccumulator;

            // Act
            Program.BasicML(0, 30, memoryLocation); // Execute ADD operation (assuming the operation code for ADD is 30)

            // Assert
            int expectedAccumulatorValue = initialValueInAccumulator + valueInMemory;
            Assert.AreEqual(expectedAccumulatorValue, Program.accumulator, "The accumulator should have the sum of the values.");
        }
        [TestMethod]
        public void TestAddOperation_InvalidMemoryLocation()
        {
            // Arrange
            int invalidMemoryLocation = 999;
            Program.accumulator = 100;

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Program.BasicML(0, 30, invalidMemoryLocation));
        }
    }

  
}