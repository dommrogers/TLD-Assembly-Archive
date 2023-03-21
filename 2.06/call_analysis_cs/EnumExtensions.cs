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
				return (T)null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(Enum), Member = "GetValues")]
		[CallsUnknownMethods(Count = 9)]
		public EnumFlagIterator(T enumFlag)
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void Dispose()
		{
		}

		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(Enum), Member = "HasFlag")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
	[CallerCount(Count = 101224)]
	public static bool HasFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return default(bool);
	}

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	[CallAnalysisNotSupported]
	public static bool HasAnyFlag<T>(this T var, T flags) where T : struct, IConvertible
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static IEnumerable<T> GetFlags<T>(this T enumFlag) where T : Enum
	{
		return null;
	}
}
