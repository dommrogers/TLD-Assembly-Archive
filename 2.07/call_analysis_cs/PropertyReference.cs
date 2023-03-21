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
		[CallerCount(Count = 92)]
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
		[CallerCount(Count = 32)]
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
		[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
		[CalledBy(Type = typeof(PropertyReference), Member = "GetPropertyType")]
		[CalledBy(Type = typeof(PropertyReference), Member = "Equals")]
		[CalledBy(Type = typeof(PropertyReference), Member = "Get")]
		[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
		[CallerCount(Count = 6)]
		get
		{
			return false;
		}
	}

	public bool isEnabled
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PropertyReference()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 268)]
	public PropertyReference(Component target, string fieldName)
	{
	}

	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[Calls(Type = typeof(PropertyReference), Member = "Cache")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public Type GetPropertyType()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CallsUnknownMethods(Count = 1)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 268)]
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
	[Calls(TypeFullName = "System.SpanHelpers", Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static string ToString(Component comp, string property)
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[Calls(Type = typeof(PropertyReference), Member = "Cache")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public object Get()
	{
		return null;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[Calls(Type = typeof(PropertyReference), Member = "Cache")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 5)]
	public bool Set(object value)
	{
		return false;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CalledBy(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Get")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private bool Cache()
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private bool Convert(ref object value)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	public static bool Convert(Type from, Type to)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	public static bool Convert(object value, Type to)
	{
		return false;
	}

	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static bool Convert(ref object value, Type from, Type to)
	{
		return false;
	}
}
