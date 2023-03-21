using System;
using System.Diagnostics;
using System.Globalization;
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
		[CallerCount(Count = 80)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
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
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
		[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
		[CalledBy(Type = typeof(PropertyReference), Member = "GetPropertyType")]
		[CalledBy(Type = typeof(PropertyReference), Member = "Equals")]
		[CalledBy(Type = typeof(PropertyReference), Member = "Get")]
		[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
		get
		{
			return default(bool);
		}
	}

	public bool isEnabled
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PropertyReference()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 263)]
	public PropertyReference(Component target, string fieldName)
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[Calls(Type = typeof(PropertyReference), Member = "Cache")]
	public Type GetPropertyType()
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 263)]
	public void Set(Component target, string methodName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Clear()
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PropertyBinding), Member = "OnValidate")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "OnValidate")]
	public void Reset()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public object Get()
	{
		return null;
	}

	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[Calls(Type = typeof(PropertyReference), Member = "Cache")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[DebuggerStepThrough]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[DebuggerHidden]
	[Calls(Type = typeof(string), Member = "Concat")]
	public bool Set(object value)
	{
		return default(bool);
	}

	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	[CalledBy(Type = typeof(PropertyReference), Member = "Get")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	private bool Cache()
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private bool Convert(ref object value)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	public static bool Convert(Type from, Type to)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	public static bool Convert(object value, Type to)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	public static bool Convert(ref object value, Type from, Type to)
	{
		return default(bool);
	}
}
