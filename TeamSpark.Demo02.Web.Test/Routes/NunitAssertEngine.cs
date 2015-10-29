﻿using MvcRouteTester.Assertions;
using NUnit.Framework;

namespace TeamSpark.Demo02.Web.Test.Routes
{
	public class NunitAssertEngine : IAssertEngine
	{
		public void Fail(string message)
		{
			Assert.Fail(message);
		}

		public void StringsEqualIgnoringCase(string s1, string s2, string message)
		{
			if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2))
			{
				return;
			}

			StringAssert.AreEqualIgnoringCase(s1, s2, message);
		}
	}
}
