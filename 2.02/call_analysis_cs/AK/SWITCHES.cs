using Cpp2ILInjected.CallAnalysis;

namespace AK;

public class SWITCHES
{
	public class AFFLICTION
	{
		public class SWITCH
		{
			public static uint BLOODLOSS;

			public static uint BURNS;

			public static uint DYSENTERY;

			public static uint FOODPOISONING;

			public static uint GENERAL;

			public static uint INFECTION;

			public static uint INTESTINALPARASITES;

			public static uint NOAFFLICTION;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public AFFLICTION()
		{
		}
	}

	public class AISTATE
	{
		public class SWITCH
		{
			public static uint ATTACK;

			public static uint DEAD;

			public static uint FEEDING;

			public static uint FLEE;

			public static uint FOLLOWWAYPOINTS;

			public static uint HOLDGROUND;

			public static uint IDLE;

			public static uint INVESTIGATE;

			public static uint INVESTIGATEFOOD;

			public static uint INVESTIGATESMELL;

			public static uint ROOTED;

			public static uint SLEEP;

			public static uint STALKING;

			public static uint STRUGGLE;

			public static uint WANDER;

			public static uint WANDERPAUSED;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public AISTATE()
		{
		}
	}

	public class ANXIETYLEVEL
	{
		public class SWITCH
		{
			public static uint HIGH;

			public static uint LOW;

			public static uint MED;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ANXIETYLEVEL()
		{
		}
	}

	public class AUDIOMATERIALS
	{
		public class SWITCH
		{
			public static uint CLIFF;

			public static uint DIRT;

			public static uint FLESH;

			public static uint GLASS;

			public static uint GRAVEL;

			public static uint ICE;

			public static uint METAL;

			public static uint RUG;

			public static uint SNOW;

			public static uint SNOWROPE;

			public static uint STONE;

			public static uint STRAW;

			public static uint WATER;

			public static uint WOOD;

			public static uint WOODSOLID;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public AUDIOMATERIALS()
		{
		}
	}

	public class AUDIOTRACKTEST
	{
		public class SWITCH
		{
			public static uint MUSICGROUP1;

			public static uint MUSICGROUP2;

			public static uint MUSICGROUP3;

			public static uint MUSICGROUP4;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public AUDIOTRACKTEST()
		{
		}
	}

	public class AURORA
	{
		public class SWITCH
		{
			public static uint AURORAOFF;

			public static uint AURORAON;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public AURORA()
		{
		}
	}

	public class AURORAELECTROLIZERONOFF
	{
		public class SWITCH
		{
			public static uint AURORAELECTROLIZEROFF;

			public static uint AURORAELECTROLIZERON;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public AURORAELECTROLIZERONOFF()
		{
		}
	}

	public class CLOTHINGTYPELOWER
	{
		public class SWITCH
		{
			public static uint HEAVYNYLON;

			public static uint LEATHER;

			public static uint LIGHTCOTTON;

			public static uint LIGHTNYLON;

			public static uint NULL;

			public static uint SOFTCLOTH;

			public static uint WOOL;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public CLOTHINGTYPELOWER()
		{
		}
	}

	public class CLOTHINGTYPEUPPER
	{
		public class SWITCH
		{
			public static uint HEAVYNYLON;

			public static uint LEATHER;

			public static uint LIGHTCOTTON;

			public static uint LIGHTNYLON;

			public static uint NULL;

			public static uint SOFTCLOTH;

			public static uint WOOL;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public CLOTHINGTYPEUPPER()
		{
		}
	}

	public class COOKINGSURFACE
	{
		public class SWITCH
		{
			public static uint FORGE;

			public static uint STONE;

			public static uint STOVE;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public COOKINGSURFACE()
		{
		}
	}

	public class CRAMPONS
	{
		public class SWITCH
		{
			public static uint DEQUIPPED;

			public static uint EQUIPPED;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public CRAMPONS()
		{
		}
	}

	public class CUTTINGTOOL
	{
		public class SWITCH
		{
			public static uint HACKSAW;

			public static uint HAMMER;

			public static uint HANDS;

			public static uint HATCHET;

			public static uint KNIFE;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public CUTTINGTOOL()
		{
		}
	}

	public class DAYNIGHT
	{
		public class SWITCH
		{
			public static uint DAY;

			public static uint NIGHT;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public DAYNIGHT()
		{
		}
	}

	public class ENTITYDISTANCE
	{
		public class SWITCH
		{
			public static uint FAR;

			public static uint MID;

			public static uint NEAR;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ENTITYDISTANCE()
		{
		}
	}

	public class ENTITYINTENSITY
	{
		public class SWITCH
		{
			public static uint HIGH;

			public static uint LOW;

			public static uint MED;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ENTITYINTENSITY()
		{
		}
	}

	public class ENVIRONMENT
	{
		public class SWITCH
		{
			public static uint EXTERIOR;

			public static uint INTERIOR;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ENVIRONMENT()
		{
		}
	}

	public class FOOTWEAR
	{
		public class SWITCH
		{
			public static uint BAREFEET;

			public static uint BOOTS;

			public static uint DEERSKIN;

			public static uint SHOES;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public FOOTWEAR()
		{
		}
	}

	public class HOWLDISTANCE
	{
		public class SWITCH
		{
			public static uint FAR;

			public static uint NEAR;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public HOWLDISTANCE()
		{
		}
	}

	public class ITEMCONDITION
	{
		public class SWITCH
		{
			public static uint HIGH;

			public static uint LOW;

			public static uint MED;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ITEMCONDITION()
		{
		}
	}

	public class NOISEMAKER
	{
		public class SWITCH
		{
			public static uint DETONATED_FALSE;

			public static uint DETONATED_TRUE;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public NOISEMAKER()
		{
		}
	}

	public class PLAYERGENDER
	{
		public class SWITCH
		{
			public static uint FEMALE;

			public static uint MALE;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public PLAYERGENDER()
		{
		}
	}

	public class STEAMPIPELEAK
	{
		public class SWITCH
		{
			public static uint STEAMPIPELEAK_OFF;

			public static uint STEAMPIPELEAK_ON;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public STEAMPIPELEAK()
		{
		}
	}

	public class STEAMPIPEPRESSURELEAK
	{
		public class SWITCH
		{
			public static uint STEAMPIPEPRESSURELEAK_OFF;

			public static uint STEAMPIPEPRESSURELEAK_ON;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public STEAMPIPEPRESSURELEAK()
		{
		}
	}

	public class SWEARFILTER
	{
		public class SWITCH
		{
			public static uint OFF;

			public static uint ON;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public SWEARFILTER()
		{
		}
	}

	public class TOGGLESWITCH
	{
		public class SWITCH
		{
			public static uint OFF;

			public static uint ON;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public TOGGLESWITCH()
		{
		}
	}

	public class URGENCY
	{
		public class SWITCH
		{
			public static uint HIGH;

			public static uint LOW;

			public static uint MED;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public URGENCY()
		{
		}
	}

	public class WEAPONFIRE
	{
		public class SWITCH
		{
			public static uint FIRE;

			public static uint MISFIRE;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public WEAPONFIRE()
		{
		}
	}

	public class WEAPONSHELLNUMDROPPED
	{
		public class SWITCH
		{
			public static uint SHELLNUM_01;

			public static uint SHELLNUM_02;

			public static uint SHELLNUM_03;

			public static uint SHELLNUM_04;

			public static uint SHELLNUM_05;

			public static uint SHELLNUM_06;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public WEAPONSHELLNUMDROPPED()
		{
		}
	}

	public class WEAPONTYPE
	{
		public class SWITCH
		{
			public static uint BAREHANDS;

			public static uint HAMMER;

			public static uint HATCHET;

			public static uint IMPROVISEDHATCHET;

			public static uint IMPROVISEDKNIFE;

			public static uint KNIFE;

			public static uint PRYBAR;

			public static uint REVOLVER;

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public SWITCH()
			{
			}
		}

		public static uint GROUP;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public WEAPONTYPE()
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public SWITCHES()
	{
	}
}
