using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xbox;

public class ErrorEventArgs : EventArgs
{
	private string _003CErrorCode_003Ek__BackingField;

	private string _003CErrorMessage_003Ek__BackingField;

	public string ErrorCode
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 80)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 279)]
		private set
		{
		}
	}

	public string ErrorMessage
	{
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 79)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	public ErrorEventArgs(string errorCode, string errorMessage)
	{
	}
}
