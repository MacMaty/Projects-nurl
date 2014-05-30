/*
 * Created by SharpDevelop.
 * User: Mathieu
 * Date: 30/05/2014
 * Time: 10:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Project_nurl
{
	 [TestFixture]   
 public class MyTest   
 {    
  [Test]    
  public void FailingTest()    
  {     
   Assert.Fail("This test fails.");    
  }   
 }  
}
