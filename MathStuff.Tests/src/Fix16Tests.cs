using NUnit.Framework;

namespace MathStuff.Tests; 

[TestFixture]
public class Fix16Tests {
	[TestCase(0f, 0f, 0f)]
	[TestCase(1f, 0f, 1f)]
	[TestCase(1f, 1f, 1f)]
	[TestCase(2f, 0f, 1f)]
	[TestCase(2f, -1f, 0f)]
	[TestCase(1f, -1f, 0f)]
	[TestCase(0.1f, 0.1f, 0.2f)]
	[TestCase(-1f, -1f, -1f)]
	public void TestAdd(float a, float b, float expected) {
		fix16 r0 = a + (fix16)b;
		fix16 r1 = (fix16) a + b;
		
		Assert.AreEqual(expected, r0, .0001f);
		Assert.AreEqual(expected, r1, .0001f);
	}
	
	[TestCase(  1f,  1f,   0f)]
	[TestCase(  1f, -1f,   1f)]
	[TestCase(0.2f,  1f,-0.8f)]
	public void TestSub(float a, float b, float expected) {
		fix16 r0 = a - (fix16)b;
		fix16 r1 = (fix16) a - b;
		
		Assert.AreEqual(expected, r0, .0001f);
		Assert.AreEqual(expected, r1, .0001f);
	}
	
	[TestCase(  0f,  1f,   0f)]
	[TestCase(  1f,  1f,   1f)]
	[TestCase( -1f,  1f,  -1f)]
	[TestCase(0.5f,  1f, 0.5f)]
	[TestCase(0.5f,0.5f,0.25f)]
	[TestCase(  2f,0.5f, 0.5f)]
	[TestCase(  2f,  1f,   1f)]
	public void TestMul(float a, float b, float expected) {
		fix16 r0 = a * (fix16)b;
		fix16 r1 = (fix16) a * b;
		
		Assert.AreEqual(expected, r0, .0001f);
		Assert.AreEqual(expected, r1, .0001f);
	}
	
	[TestCase(  1f,   1f,   1f)]
	[TestCase(0.5f, 0.5f,   1f)]
	[TestCase(0.2f, 0.5f, 0.4f)]
	[TestCase(0.2f,-0.5f,-0.4f)]
	public void TestDiv(float a, float b, float expected) {
		fix16 r0 = a / (fix16)b;
		fix16 r1 = (fix16) a / b;
		
		Assert.AreEqual(expected, r0, .0001f);
		Assert.AreEqual(expected, r1, .0001f);
	}
	
	[TestCase( 0.2f,0.2f)]
	[TestCase(   1f,  1f)]
	[TestCase(  -1f,  1f)]
	[TestCase(-0.1f,0.1f)]
	public void TestAbs(float a, float expected) {
		fix16 r0 = ((fix16) a).abs;
		Assert.AreEqual(expected, r0, .0001f);
	}
	
	[TestCase( 0.1f, 0)]
	[TestCase(-0.1f, 1)]
	[TestCase(    0, 0)]
	[TestCase(    1, 0)]
	[TestCase(   -1, 1)]
	public void TestSign(float a, int expected) {
		int r0 = ((fix16) a).sign;
		Assert.AreEqual(expected, r0, .0001f);
	}
}