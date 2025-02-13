/********************************************************************\
*                                                                   *
*  Bloodmasters engine by Pascal vd Heiden, www.codeimp.com         *
*  All code in this file is my own design. You are free to use it.  *
*                                                                   *
\********************************************************************/

using System;
using System.Drawing;
using System.Collections;
using CodeImp.Bloodmasters;
using CodeImp;

#if CLIENT
using CodeImp.Bloodmasters.Client;
#endif

namespace CodeImp.Bloodmasters.Server
{
	[ServerItem(8004, RespawnTime=5000)]
	public class AmmoGrenades : Item
	{
		#region ================== Constants
		
		#endregion
		
		#region ================== Variables
		
		#endregion
		
		#region ================== Constructor / Destructor
		
		// Constructor
		public AmmoGrenades(Thing t) : base(t)
		{
		}
		
		#endregion
		
		#region ================== Control
		
		// This is called when the item is being touched by a player
		public override void Pickup(Client c)
		{
			// Give clietn ammo if possible
			if(c.AddAmmo(AMMO.GRENADES, 10))
			{
				// Do what you have to do
				base.Pickup(c);
				
				// Take the item
				this.Take(c);
			}
		}
		
		#endregion
	}
}
