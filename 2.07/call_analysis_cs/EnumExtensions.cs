using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public static class EnumExtensions
{
	public struct EnumFlagIterator<T> : IDisposable, IEnumerator<T>, IEnumerable<T>, IEnumerable, IEnumerator where T : Enum
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
				return (T)null;
			}
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 14)]
		public EnumFlagIterator(T enumFlag)
		{
		}

		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void Dispose()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "HasFlag")]
		[CallsUnknownMethods(Count = 6)]
		public bool MoveNext()
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void Reset()
		{
		}
	}

	[DeduplicatedMethod]
	[CallAnalysisNotSupported]
	[CallerCount(Count = 101261)]
	public static bool HasFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallAnalysisNotSupported]
	[CallerCount(Count = 101261)]
	public static bool HasAnyFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static IEnumerable<T> GetFlags<T>(this T enumFlag) where T : Enum
	{
		return null;
	}
}
