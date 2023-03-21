using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

public class fsMetaProperty
{
	private FieldInfo _fieldInfo;

	private Type _003CStorageType_003Ek__BackingField;

	private string _003CJsonName_003Ek__BackingField;

	public Type StorageType
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public string JsonName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public string MemberName
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(fsMetaType), Member = "CollectProperties")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	internal fsMetaProperty(fsConfig config, FieldInfo field)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Write(object context, object value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public object Read(object context)
	{
		return null;
	}
}
