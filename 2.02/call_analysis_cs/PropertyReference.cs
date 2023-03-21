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
		[CallerCount(Count = 52)]
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
		[CallerCount(Count = 29)]
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
		[CalledBy(Type = typeof(PropertyReference), Member = "Equals")]
		[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
		[CalledBy(Type = typeof(PropertyReference), Member = "Get")]
		[CalledBy(Type = typeof(PropertyReference), Member = "GetPropertyType")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
		[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
		get
		{
			return default(bool);
		}
	}

	public bool isEnabled
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		get
		{
			return default(bool);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PropertyReference()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 83)]
	public PropertyReference(Component target, string fieldName)
	{
	}

	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[Calls(Type = typeof(PropertyReference), Member = "Cache")]
	public Type GetPropertyType()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 83)]
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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public override string ToString()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[CallsUnknownMethods(Count = 3)]
	public static string ToString(Component comp, string property)
	{
		return null;
	}

	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[Calls(Type = typeof(PropertyReference), Member = "Cache")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[DebuggerStepThrough]
	[DebuggerHidden]
	public object Get()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(PropertyReference), Member = "Cache")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(PropertyReference), Member = "get_isValid")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 27)]
	[DebuggerHidden]
	[CalledBy(Type = typeof(PropertyBinding), Member = "UpdateTarget")]
	[DebuggerStepThrough]
	public bool Set(object value)
	{
		return default(bool);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	[CalledBy(Type = typeof(PropertyReference), Member = "Get")]
	[CalledBy(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(Type), Member = "GetProperty")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	private bool Cache()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PropertyReference), Member = "GetPropertyType")]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool Convert(ref object value)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	[CallerCount(Count = 0)]
	public static bool Convert(Type from, Type to)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PropertyReference), Member = "Convert")]
	public static bool Convert(object value, Type to)
	{
		return default(bool);
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Convert")]
	[CalledBy(Type = typeof(PropertyReference), Member = "Set")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static bool Convert(ref object value, Type from, Type to)
	{
		return default(bool);
	}
}
