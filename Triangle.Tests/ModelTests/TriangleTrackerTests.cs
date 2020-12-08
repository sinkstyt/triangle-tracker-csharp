using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void EvaluateTriangle_ReturnsSumOfThreeIntegersWhenPassedThreeIntegers_SideOneSideTwoSideThree()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual(3 + 4 + 6, testTriangleTracker.EvaluateTriangle(3, 4, 6));
    }
  }
}