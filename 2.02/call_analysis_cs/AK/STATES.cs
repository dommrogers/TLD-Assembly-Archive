using Cpp2ILInjected.CallAnalysis;

namespace AK;

public class STATES
{
	public class BRIDGE
	{
		public class STATE
		{
			public static uint SUSPENSION;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public BRIDGE()
		{
		}
	}

	public class BRIDGE_SUSPENSION
	{
		public class STATE
		{
			public static uint SUSPENSION00;

			public static uint SUSPENSION01;

			public static uint SUSPENSION02;

			public static uint SUSPENSION03;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public BRIDGE_SUSPENSION()
		{
		}
	}

	public class DAMAGESOURCE
	{
		public class STATE
		{
			public static uint NOISEMAKER;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public DAMAGESOURCE()
		{
		}
	}

	public class DIALOGUEMODE
	{
		public class STATE
		{
			public static uint DAILOGUEMODE_OFF;

			public static uint DAILOGUEMODE_ON;

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public DIALOGUEMODE()
		{
		}
	}

	public class FOURDAYSOFNIGHT
	{
		public class STATE
		{
			public static uint FALSE;

			public static uint TRUE;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public FOURDAYSOFNIGHT()
		{
		}
	}

	public class GAMEMODE
	{
		public class STATE
		{
			public static uint SANDBOX;

			public static uint STORYEP01EP02;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public GAMEMODE()
		{
		}
	}

	public class INTENSITY
	{
		public class STATE
		{
			public static uint INT00;

			public static uint INT01;

			public static uint INT02;

			public static uint INT03;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public INTENSITY()
		{
		}
	}

	public class INTERIORSTATES
	{
		public class STATE
		{
			public static uint EXT;

			public static uint FL01;

			public static uint FL01R01;

			public static uint FL01R02;

			public static uint FL01R03;

			public static uint FL01R04;

			public static uint FL02;

			public static uint FL02R01;

			public static uint FL02R02;

			public static uint FL02R03;

			public static uint FL02R04;

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public INTERIORSTATES()
		{
		}
	}

	public class MISOPHONIA
	{
		public class STATE
		{
			public static uint OFF;

			public static uint ON;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public MISOPHONIA()
		{
		}
	}

	public class OCCLUSIONSTATES
	{
		public class STATE
		{
			public static uint HEAVYOCCLUSION;

			public static uint MAINMENU;

			public static uint MEDIUMOCCLUSION;

			public static uint MILDOCCLUSION;

			public static uint NOOCCLUSION;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public OCCLUSIONSTATES()
		{
		}
	}

	public class RIVERFILTER
	{
		public class STATE
		{
			public static uint RIVERFILTEROFF;

			public static uint RIVERFILTERON;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public RIVERFILTER()
		{
		}
	}

	public class SCENEDESTRUCTION
	{
		public class STATE
		{
			public static uint SCENEDESTRUCTION_OFF;

			public static uint SCENEDESTRUCTION_ON;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SCENEDESTRUCTION()
		{
		}
	}

	public class SCENEENVIRONMENT
	{
		public class STATE
		{
			public static uint SE_CELLBLOCK;

			public static uint SE_STEAMTUNNEL;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SCENEENVIRONMENT()
		{
		}
	}

	public class SPOTLIGHTSTAGESTATE
	{
		public class STATE
		{
			public static uint STAGE00;

			public static uint STAGE01;

			public static uint STAGE02;

			public static uint STAGE03;

			public static uint STAGE04;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SPOTLIGHTSTAGESTATE()
		{
		}
	}

	public class SUFFOCATION
	{
		public class STATE
		{
			public static uint SUFFOCATEOFF;

			public static uint SUFFOCATEON;

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public SUFFOCATION()
		{
		}
	}

	public class WEATHERSTATE
	{
		public class STATE
		{
			public static uint BLIZZARD;

			public static uint CLEAR;

			public static uint CLOUDY;

			public static uint DENSEFOG;

			public static uint HEAVYSNOW;

			public static uint LIGHTFOG;

			public static uint LIGHTSNOW;

			public static uint PARTLYCLOUDY;

			public static uint TOXICFOG;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public WEATHERSTATE()
		{
		}
	}

	public class WIELDSTATE
	{
		public class STATE
		{
			public static uint WIELDFALSE;

			public static uint WIELDTRUE;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public WIELDSTATE()
		{
		}
	}

	public class WINDLOCATION
	{
		public class STATE
		{
			public static uint COAST;

			public static uint DEFAULT;

			public static uint FIELD;

			public static uint FOREST;

			public static uint MARSH;

			public static uint MOUNTAIN;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public STATE()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public WINDLOCATION()
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public STATES()
	{
	}
}
