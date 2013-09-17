/*
 * Created by SharpDevelop.
 * User: RicardoAlfonso
 * Date: 17/09/2013
 * Time: 05:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejemplo.Properties
{
	/// <summary>
	/// Description of cronometro.
	/// </summary>
	public class cronometro
	{
		public cronometro()
		{
			for(int h=0;h<24;h++){
				for (int m=0;m<60;m++){
				for (int s=0;s<60;s++){
						Console.Clear();
						Console.WriteLine(h+":"+m+":"+s);
						System.Threading.Thread.Sleep (1000);
					}
				}
			}
		}
	}
}
