using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting;

public struct UserReportScreenshot
{
	private string _003CDataBase64_003Ek__BackingField;

	private string _003CDataIdentifier_003Ek__BackingField;

	private int _003CFrameNumber_003Ek__BackingField;

	public string DataBase64
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		set
		{
		}
	}

	public string DataIdentifier
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int FrameNumber
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int Height
	{
		[CalledBy(Type = typeof(UserReport), Member = "RemoveScreenshots")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(Convert), Member = "FromBase64String")]
		[Calls(Type = typeof(PngHelper), Member = "Slice")]
		[Calls(Type = typeof(Array), Member = "Reverse")]
		[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public int Width
	{
		[CalledBy(Type = typeof(UserReport), Member = "RemoveScreenshots")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "Substring")]
		[Calls(Type = typeof(Convert), Member = "FromBase64String")]
		[Calls(Type = typeof(PngHelper), Member = "Slice")]
		[Calls(Type = typeof(Array), Member = "Reverse")]
		[Calls(Type = typeof(BitConverter), Member = "ToInt32")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return 0;
		}
	}
}
