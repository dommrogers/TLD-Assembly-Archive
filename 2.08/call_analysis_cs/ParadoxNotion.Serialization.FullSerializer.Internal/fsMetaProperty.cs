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
		[CallerCount(Count = 28)]
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

	public string JsonName
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[CallerCount(Count = 55)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		private set
		{
		}
	}

	public string MemberName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(fsMetaType), Member = "CollectProperties")]
	[CallsUnknownMethods(Count = 1)]
	internal fsMetaProperty(fsConfig config, FieldInfo field)
	{
	}

	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Write(object context, object value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public object Read(object context)
	{
		return null;
	}
}
