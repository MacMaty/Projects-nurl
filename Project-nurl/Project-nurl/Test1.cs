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
		
		
		[Test]
public void Should_show_the_content_of_a_page()
{
    //given
    var command = null ;//votre implémentation

    //when
    var result = command.Show(url); //exemple d'implémentation

    //then

    Assert.That(result, Is.EqualTo("<h1>hello</h1>"));
}
 }  
}
