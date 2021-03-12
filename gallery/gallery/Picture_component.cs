using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace gallery
{
	public class PictureLogic
	{
		public static bool AddPicture(Context c, string name, .....)
		{
			//validate
			Picture p = new Picture();
			p.Name = name;
			//....

			c.Pictures.Add(p);
			c.SaveChanges();
			return true;
		}
	}
}