using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting;

public struct UserReportAttachment
{
	private string _003CContentType_003Ek__BackingField;

	private string _003CDataBase64_003Ek__BackingField;

	private string _003CDataIdentifier_003Ek__BackingField;

	private string _003CFileName_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	public string ContentType
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		set
		{
		}
	}

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
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string DataIdentifier
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 101)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public string FileName
	{
		[CallerCount(Count = 29)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public string Name
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToBase64String")]
	[CalledBy(Type = typeof(UserReportingScript), Member = "<CreateUserReport>b__29_2")]
	[CalledBy(Type = typeof(AttachmentExtensions), Member = "AddJson")]
	[CalledBy(Type = typeof(AttachmentExtensions), Member = "AddText")]
	public UserReportAttachment(string name, string fileName, string contentType, byte[] data)
	{
	}
}
