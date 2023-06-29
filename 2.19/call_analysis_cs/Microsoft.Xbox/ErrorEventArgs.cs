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
		[CallerCount(Count = 92)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 283)]
		private set
		{
		}
	}

	public string ErrorMessage
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 86)]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	public ErrorEventArgs(string errorCode, string errorMessage)
	{
	}
}
