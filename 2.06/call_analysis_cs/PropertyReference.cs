using System;
using System.Diagnostics;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class PropertyReference
{
	private Component mTarget;

	private string mName;

	private FieldInfo mField;

	private PropertyInfo mProperty;

	private static int s_Hash;

	public Component target
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 98)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string name
	{
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool isValid
	{
		[CalledBy(Type = typeof(PropertyReference), Member = "GetPropertyType")]
		[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
		[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(PropertyReference), Member = "Get")]
		[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
		[CalledBy(Type = typeof(PropertyReference), Member = "Equals")]
		get
		{
			return default(bool);
		}
	}

	public bool isEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PropertyReference()
	{
	}

	[CallerCount(Count = 224)]
	[DeduplicatedMethod]
	public PropertyReference(Component target, string fieldName)
	{
	}

	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(PropertyReference), Member = "Cache")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	public Type GetPropertyType()
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 224)]
	public void Set(Component target, string methodName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[CalledBy(Type = typeof(PropertyBinding), Member = "OnValidate")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PropertyBinding), Member = "OnValidate")]
	public void Reset()
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	public override string ToString()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public static string ToString(Component comp, string property)
	{
		return null;
	}

	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[Calls(Type = typeof(PropertyReference), Member = "Cache")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[DebuggerHidden]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerStepThrough]
	public object Get()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[Calls(Type = typeof(PropertyReference), Member = "Cache")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[CallerCount(Count = 1)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[CallsDeduplicatedMethods(Count = 8)]
	public bool Set(object value)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Get")]
	[CalledBy(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(Type), Member = "GetProperty")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	private bool Cache()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	private bool Convert(ref object value)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	[CallerCount(Count = 0)]
	public static bool Convert(Type from, Type to)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	[CallerCount(Count = 0)]
	public static bool Convert(object value, Type to)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static bool Convert(ref object value, Type from, Type to)
	{
		return default(bool);
	}
}
