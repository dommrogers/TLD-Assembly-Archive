using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public static class EnumExtensions
{
	public struct EnumFlagIterator<T> : IEnumerator<T>, IEnumerator, IDisposable, IEnumerable<T>, IEnumerable where T : Enum
	{
		private T m_EnumFlag;

		private T[] m_EnumArray;

		private int m_Index;

		public object Current
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 4)]
			get
			{
				return null;
			}
		}

		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			get
			{
				return default(T);
			}
		}

		[DeduplicatedMethod]
		[CalledBy(Type = typeof(GearItem), Member = "IsAnyGearType")]
		[CalledBy(Type = typeof(EnumExtensions), Member = "GetFlags")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 14)]
		public EnumFlagIterator(T enumFlag)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void Dispose()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "HasFlag")]
		[CallsUnknownMethods(Count = 6)]
		public bool MoveNext()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void Reset()
		{
		}
	}

	public static bool HasFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return false;
	}

	public static bool HasAnyFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EnumFlagIterator<>), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<T> GetFlags<T>(this T enumFlag) where T : Enum
	{
		return null;
	}
}
