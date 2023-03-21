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
				return default(byte);
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
		[CalledBy(Type = typeof(AkTriggerBase), Member = "GetAllDerivedTypes")]
		[CalledBy(Type = typeof(AkTriggerBase), Member = "GetAllDerivedTypes")]
		[CalledBy(Type = typeof(AkTriggerBase), Member = "GetAllDerivedTypes")]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(string), Member = "ToLower")]
		public static uint Compute(string in_name)
		{
			return default(uint);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ShortIDGenerator()
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AkUtilities()
	{
	}
}
