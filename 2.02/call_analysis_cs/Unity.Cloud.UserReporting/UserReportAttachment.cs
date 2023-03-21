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
		[CallerCount(Count = 59)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 103)]
		set
		{
		}
	}

	public string FileName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 35)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 77)]
		set
		{
		}
	}

	public string Name
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 44)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(UserReportingScript), Member = "<CreateUserReport>b__29_2")]
	[CalledBy(Type = typeof(AttachmentExtensions), Member = "AddJson")]
	[CalledBy(Type = typeof(AttachmentExtensions), Member = "AddText")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Convert), Member = "ToBase64String")]
	[CallsDeduplicatedMethods(Count = 1)]
	public UserReportAttachment(string name, string fileName, string contentType, byte[] data)
	{
	}
}
