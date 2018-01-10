using System;
using System.Collections;
using UnityEngine;

namespace AssemblyCSharp
{
	public class PlayerMov
	{
		public float speed;
		private Vector2 direction;
	
		public PlayerMov (float spd)
		{
			speed = spd;
		}

		public Vector2 SpeedCalc (Vector2 drct){
			return (speed * drct.normalized);
		}
	}
}

