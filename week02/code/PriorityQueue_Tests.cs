using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create 3 elements with different priority, then the Dequeue return the element with the main priority.
    // Expected Result: "B" because it has the main priority.
    // Defect(s) Found: Dequeue didn't remove the item with the high priority
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);
        var first = priorityQueue.Dequeue();

        Assert.AreEqual("B", first);
    }

    [TestMethod]
    // Scenario: Create multiple elements with the same priority, If there are multiple values with the same 
    // high priority, then the first one (following the FIFO strategy) is removed first.
    // Expected Result: B, C, 2, 1
    // Defect(s) Found: Dequeue didn't remove the first item entered when multiples items had the same priority.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 3);
        priorityQueue.Enqueue("D", 1);

        var first = priorityQueue.Dequeue();

        Assert.AreEqual("B", first);

        var second = priorityQueue.Dequeue();
        Assert.AreEqual("C", second);

        var third = priorityQueue.Dequeue();
        Assert.AreEqual("A", third);
    }

    // Add more test cases as needed below.
}