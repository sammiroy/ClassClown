using System;
using System.Collections.Generic;

namespace ClassClown
{
	public class Backpack
	{
		// Fields
		private string color;
		private string size;
		private List<string> items = new List<string>();
		private bool open;

		// Constructor
		public Backpack(string Color, string Size)
		{
			color = Color;
			size = Size;
			items = new List<string>();
			open = false;
		}

		// Methods
		public void OpenBag()
        {
			this.open = true;
        }

		public void CloseBag()
        {
			this.open = false;
        }

		public void PutIn(string item)
        {
			item = item.ToLower();
			if (!open)
			{
				Console.WriteLine($"Cannot add {item} to the {this.size}, {this.color} backpack, it is closed");
				return;
			}
			this.items.Add(item);
			Console.WriteLine($"Added {item} to the {this.size}, {this.color} backpack");
        }

		public void TakeOut(string item)
        {
			item = item.ToLower();
			if (!open)
            {
				Console.WriteLine($"Cannot take {item} from the {this.size}, {this.color} backpack, it is closed");
				return;
			} else if (!this.items.Contains(item))
            {
				Console.WriteLine($"Cannot take {item} from the {this.size}, {this.color} backpack, it is not in this backpack!");
				return;
			}
			this.items.Remove(item);
			Console.WriteLine($"Removed {item} from the {this.size}, {this.color} backpack");

		}
	}
}