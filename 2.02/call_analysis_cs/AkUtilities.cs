using System.Text;
using Cpp2ILInjected.CallAnalysis;

public class AkUtilities
{
	public class ShortIDGenerator
	{
		private const uint s_prime32 = 16777619u;

		private const uint s_offsetBasis32 = 2166136261u;

		private static byte s_hashSize;

		private static uint s_mask;

		public static byte HashSize
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			get
			{
				return 0;
			}
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			set
			{
			}
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		static ShortIDGenerator()
		{
		}

		[CalledBy(Type = typeof(AkTriggerBase), Member = "GetAllDerivedTypes")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
		[Calls(Type = typeof(string), Member = "ToLower")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		public static uint Compute(string in_name)
		{
			return 0u;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ShortIDGenerator()
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AkUtilities()
	{
	}
}
