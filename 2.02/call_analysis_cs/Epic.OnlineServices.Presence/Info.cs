using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Presence;

public class Info : ISettable
{
	private Status _003CStatus_003Ek__BackingField;

	private EpicAccountId _003CUserId_003Ek__BackingField;

	private string _003CProductId_003Ek__BackingField;

	private string _003CProductVersion_003Ek__BackingField;

	private string _003CPlatform_003Ek__BackingField;

	private string _003CRichText_003Ek__BackingField;

	private DataRecord[] _003CRecords_003Ek__BackingField;

	private string _003CProductName_003Ek__BackingField;

	public Status Status
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		get
		{
			return default(Status);
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public EpicAccountId UserId
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

	public string ProductId
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

	public string ProductVersion
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 24)]
		set
		{
		}
	}

	public string Platform
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 17)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		set
		{
		}
	}

	public string RichText
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
		[CallerCount(Count = 18)]
		set
		{
		}
	}

	public DataRecord[] Records
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
		[CallerCount(Count = 46)]
		set
		{
		}
	}

	public string ProductName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
		set
		{
		}
	}

	[CalledBy(Type = typeof(Info), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InfoInternal), Member = "get_UserId")]
	[Calls(Type = typeof(InfoInternal), Member = "get_ProductId")]
	[Calls(Type = typeof(InfoInternal), Member = "get_ProductVersion")]
	[Calls(Type = typeof(InfoInternal), Member = "get_Platform")]
	[Calls(Type = typeof(InfoInternal), Member = "get_RichText")]
	[Calls(Type = typeof(InfoInternal), Member = "get_Records")]
	[Calls(Type = typeof(InfoInternal), Member = "get_ProductName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal void Set(InfoInternal? other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Info), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Set(object other)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Info()
	{
	}
}
