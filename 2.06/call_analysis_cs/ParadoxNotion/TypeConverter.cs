using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace ParadoxNotion;

public static class TypeConverter
{
	public delegate Func<object, object> CustomConverter(Type fromType, Type toType);

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public Type toType;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Convert), Member = "ChangeType")]
		[Calls(Type = typeof(Activator), Member = "CreateInstance")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal object _003CGet_003Eb__2(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal object _003CGet_003Eb__4(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal object _003CGet_003Eb__6(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal object _003CGet_003Eb__7(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal object _003CGet_003Eb__8(object value)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<object, object> _003C_003E9__4_0;

		public static Func<object, object> _003C_003E9__4_1;

		public static Func<object, object> _003C_003E9__4_3;

		public static Func<object, object> _003C_003E9__4_5;

		public static Func<object, object> _003C_003E9__4_9;

		public static Func<object, object> _003C_003E9__4_10;

		public static Func<object, object> _003C_003E9__4_11;

		public static Func<object, object> _003C_003E9__4_12;

		public static Func<object, object> _003C_003E9__4_13;

		public static Func<object, object> _003C_003E9__4_14;

		public static Func<object, object> _003C_003E9__4_15;

		public static Func<object, object> _003C_003E9__4_16;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal object _003CGet_003Eb__4_0(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		internal object _003CGet_003Eb__4_1(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		internal object _003CGet_003Eb__4_3(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 2)]
		internal object _003CGet_003Eb__4_5(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal object _003CGet_003Eb__4_9(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal object _003CGet_003Eb__4_10(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal object _003CGet_003Eb__4_11(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		internal object _003CGet_003Eb__4_12(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
		[CallsUnknownMethods(Count = 2)]
		internal object _003CGet_003Eb__4_13(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal object _003CGet_003Eb__4_14(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal object _003CGet_003Eb__4_15(object value)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal object _003CGet_003Eb__4_16(object value)
		{
			return null;
		}
	}

	public static event CustomConverter customConverter
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(TypeConverter), Member = "CanConvert")]
	[CalledBy(Type = typeof(Variable), Member = "GetGetConverter")]
	[CalledBy(Type = typeof(Variable), Member = "GetSetConverter")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[CallsDeduplicatedMethods(Count = 25)]
	[CallsUnknownMethods(Count = 99)]
	public static Func<object, object> Get(Type fromType, Type toType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeConverter), Member = "Get")]
	public static bool CanConvert(Type fromType, Type toType)
	{
		return false;
	}
}
