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
		[CallerCount(Count = 98)]
		get
		{
			return null;
		}
		[CallerCount(Count = 265)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public string ErrorMessage
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	public ErrorEventArgs(string errorCode, string errorMessage)
	{
	}
}
