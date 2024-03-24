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
            string filePath = @"c:/temp/NOFILEHEREMUAHAHA.txt"; 

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
        [TestMethod]
        public void TestWriteOperation_InvalidMemoryLocation()
        {
            // Arrange
            int invalidMemoryLocation = 999; // Assuming this is out of range
            var originalOutput = Console.Out; // Preserve the original output stream
            using var writer = new StringWriter();
            Console.SetOut(writer); // Redirect console output to the StringWriter

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                Program.BasicML(0, 11, invalidMemoryLocation));

            // Cleanup
            Console.SetOut(originalOutput); // Restore original output stream
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
            Program.BasicML(0, 21, memoryLocation); // Execute STORE operation

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
            Program.BasicML(0, 30, memoryLocation); // Execute ADD operation 

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
    [TestClass]
    public class SubtractOperationTests
    {
        [TestMethod]
        public void TestSubtractOperation_Success()
        {
            // Arrange
            int memoryLocation = 10;
            Program.memory[memoryLocation] = 200; // Value to subtract
            Program.accumulator = 500; // Initial accumulator value

            // Act
            Program.BasicML(0, 31, memoryLocation); // Execute SUBTRACT operation

            // Assert
            Assert.AreEqual(300, Program.accumulator, "Accumulator should have the correct difference after subtraction.");
        }

        [TestMethod]
        public void TestSubtractOperation_InvalidMemoryLocation()
        {
            // Arrange
            int invalidMemoryLocation = 999; // Out of range location
            Program.accumulator = 500; // Any initial value

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                Program.BasicML(0, 31, invalidMemoryLocation));
        }
    }
    [TestClass]
    public class DivideOperationTests
    {
        [TestMethod]
        public void TestDivideOperation_Success()
        {
            // Arrange
            int memoryLocation = 10;
            Program.memory[memoryLocation] = 200; // Divider value
            Program.accumulator = 400; // Initial accumulator value

            // Act
            Program.BasicML(0, 32, memoryLocation); // Execute DIVIDE operation

            // Assert
            Assert.AreEqual(2, Program.accumulator, "Accumulator should have the correct division result.");
        }
        [TestMethod]
        public void TestDivideOperation_DivideByZero()
        {
            // Arrange
            int memoryLocation = 10;
            Program.memory[memoryLocation] = 0; // Divider value set to zero
            Program.accumulator = 400; // Any initial value

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() =>
                Program.BasicML(0, 32, memoryLocation));
        }
    }
    [TestClass]
    public class MultiplyOperationTests
    {
        [TestMethod]
        public void TestMultiplyOperation_Success()
        {
            // Arrange
            int memoryLocation = 10;
            Program.memory[memoryLocation] = 5; // Value to multiply
            Program.accumulator = 4; // Initial accumulator value

            // Act
            Program.BasicML(0, 33, memoryLocation); // Execute MULTIPLY operation

            // Assert
            Assert.AreEqual(20, Program.accumulator, "Accumulator should have the correct multiplication result.");
        }
        [TestMethod]
        public void TestMultiplyOperation_InvalidMemoryLocation()
        {
            // Arrange
            int invalidMemoryLocation = 999; // Out of range location
            Program.accumulator = 4; // Any initial value

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                Program.BasicML(0, 33, invalidMemoryLocation));
        }
    }
    [TestClass]
    public class BranchNegOperationTests
    {
        [TestMethod]
        public void TestBranchNegOperation_WithNegativeAccumulator()
        {
            // Arrange
            int branchLocation = 10; // Memory location to branch to
            Program.accumulator = -5; // Negative accumulator value

            // Act
            int nextInstruction = Program.BasicML(0, 41, branchLocation);

            // Assert
            Assert.AreEqual(branchLocation, nextInstruction, "Program should branch to the specified memory location.");
        }
        [TestMethod]
        public void TestBranchNegOperation_WithNonNegativeAccumulator()
        {
            // Arrange
            int branchLocation = 10; // Memory location to branch to
            int currentInstruction = 0; // Current instruction index
            Program.accumulator = 5; // Non-negative accumulator value

            // Act
            int nextInstruction = Program.BasicML(currentInstruction, 41, branchLocation);

            // Assert
            Assert.AreEqual(currentInstruction + 1, nextInstruction, "Program should not branch and proceed to the next instruction.");
        }
    }
    [TestClass]
    public class BranchZeroOperationTests
    {
        [TestMethod]
        public void TestBranchZeroOperation_WithZeroAccumulator()
        {
            // Arrange
            int branchLocation = 10; // Memory location to branch to
            Program.accumulator = 0; // Accumulator value set to zero

            // Act
            int nextInstruction = Program.BasicML(0, 42, branchLocation);

            // Assert
            Assert.AreEqual(branchLocation, nextInstruction, "Program should branch to the specified memory location when accumulator is zero.");
        }
        [TestMethod]
        public void TestBranchZeroOperation_WithNonZeroAccumulator()
        {
            // Arrange
            int branchLocation = 10; // Memory location to branch to
            int currentInstruction = 0; // Current instruction index
            Program.accumulator = 5; // Non-zero accumulator value

            // Act
            int nextInstruction = Program.BasicML(currentInstruction, 42, branchLocation);

            // Assert
            Assert.AreEqual(currentInstruction + 1, nextInstruction, "Program should not branch and proceed to the next instruction when accumulator is non-zero.");
        }
    }
    [TestClass]
    public class HaltOperationTests
    {
        [TestMethod]
        public void TestHaltOperation()
        {
            // Arrange
            // Set up any necessary initial conditions

            // Act
            int result = Program.BasicML(0, 43, 0); // Execute HALT operation

            // Assert
            Assert.AreEqual(-1, result, "The result should indicate that the program has halted.");
        }
    }


}