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
		[CallerCount(Count = 113)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 269)]
		private set
		{
		}
	}

	public string ErrorMessage
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 93)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	public ErrorEventArgs(string errorCode, string errorMessage)
	{
	}
}
